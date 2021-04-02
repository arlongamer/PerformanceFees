using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.CSharp;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using SharedObjects;




namespace PerformanceFees
{
    public class CCDynamicCode
    {
        
    }

    public class CCompiler
    {

        public string _baseCode;
        public string _compilerOutput;
        public string _runOutput;
        public CompilerResults _compilerResults; 
        public MethodInfo _main ;
        public bool _precompileReady;


        // used for primitives injection
        public string _injection_definition ;
        public string _injection_constructor;
        public string _injection_primitives ;

        public CCompiler()
        {
            _injection_definition = "";
            _injection_constructor = "";
            _injection_primitives = "";

            _compilerOutput = "";
            _runOutput = "";
            _baseCode =
          @"
                    using System;
                    using System.Text;
                    using System.Globalization;

                    using SharedObjects;


                    namespace DynamicCompiler
                    {
                        public class Program
                        {
                            public static string info;
                            public static string _feedBack;
                            public static CCellMatrix _theMatrix ;

                            ///injection_definition///

                            public Program()
                            {
                                info = ""Fee compiler by P2"";
                                _feedBack = """";

                            }

                            ///injection_primitives///

                            public static void Main()
                            {
                                Console.WriteLine(""You are in the main "");
                            }

                            public static void Info(string pInfo) 
                            {
                                info = info + "" \n"" + pInfo ;
                            }

                            public static void FeedBack(string pFeedBack) 
                            {
                                _feedBack = _feedBack+ "" \n"" + pFeedBack ;
                            }

                            public static double Valeur(string pFieldName) 
                            {
                                double returnValue ;
                                string theValue = _theMatrix._currentVector.GetCellValue(pFieldName);
                                
                                returnValue = GetDouble( theValue , -999999.999999) ;

                                if ( returnValue ==-999999.999999) 
                                    throw new FieldIsNAException(pFieldName);

                                FeedBack(""Field "" +   pFieldName  + "" value: ""+returnValue.ToString());

                                return returnValue;
                            }

                            public static double PrevValeur(string pFieldName) 
                            {
                                double returnValue ;
                                string theValue =  _theMatrix._previousVector.GetCellValue(pFieldName);
                                
                                returnValue = GetDouble( theValue , -999999.999999) ;
                                if ( returnValue ==-999999.999999) 
                                    throw new FieldIsNAException(pFieldName);

                                return returnValue;
                            }


                            public static void DoInitialisePrimitives()
                            {
                                ///injection_construtor///
                            }
                            public static string Eval(CCellMatrix pTheMatrix )
                            {
                                DoInitialisePrimitives();

                                _theMatrix  = pTheMatrix ;
                            
                                double Value = -999999.999999;

                                pTheMatrix._lastCellStatus = ECellStatus.Clean;

                                Console.WriteLine(""You are in the Eval"");
                                Console.WriteLine(""Element in vector: "" + _theMatrix._currentVector.VectorSize());
                                Info(""Element in current vector : "" + _theMatrix._currentVector.VectorSize());
                            
                                try
                                {
                                    FeedBack( ""Run from "" + DateTime.Now.ToString());

                                    ///injection///


                                    if ( double.IsInfinity(Value) )
                                        throw new DivideByZeroException ();

                                    pTheMatrix._lastEvaluatedIsNa = false ;
                                    pTheMatrix._lastEvaluatedValue = Value.ToString() ;

                                    FeedBack( "" Successfull calculation, returned value: "" + pTheMatrix._lastEvaluatedValue  );
                                }
                                catch (InvalidFieldException e) 
                                {
                                    Info(""The field "" + e.Message + "" was not found."");
                                     
                                    pTheMatrix._lastCellStatus = ECellStatus.N_A;
                                    pTheMatrix._lastEvaluatedValue = ""N/A"";
                                    pTheMatrix._lastEvaluatedIsNa = true ;

                                    FeedBack(""The field "" + e.Message + "" was not found."");
                                    FeedBack( "" Unsuccessfull calculation, returned value: N_A"" );

                                }
                                catch (FieldIsNAException e) 
                                {
                                    Info(""The field "" + e.Message + "" has N_A value."");
                                     
                                    pTheMatrix._lastCellStatus = ECellStatus.N_A;
                                    pTheMatrix._lastEvaluatedValue = ""N/A"";
                                    pTheMatrix._lastEvaluatedIsNa = true ;

                                    FeedBack(""The field "" + e.Message + "" has N_A value."");
                                    FeedBack( "" Unsuccessfull calculation, returned value: N_A"" );

                                }

                                catch (DivideByZeroException e) 
                                {
                                    Info(""Division by zero ""  );
                                    pTheMatrix._lastCellStatus = ECellStatus.Error;
                                    pTheMatrix._lastEvaluatedValue = ""Error"";
                                    pTheMatrix._lastEvaluatedIsNa = true ;

                                    FeedBack(""Division by zero "" + e);
                                    FeedBack( "" Unsuccessfull calculation, returned value: Error"" );

                                }

                                catch (Exception e)
                                {
                                    Info(""Other error: "" + e );
                                    pTheMatrix._lastCellStatus = ECellStatus.Error;
                                    pTheMatrix._lastEvaluatedValue = ""Error"";
                                    pTheMatrix._lastEvaluatedIsNa = true ;

                                    FeedBack(""Other error: "" + e );
                                    FeedBack( "" Unsuccessfull calculation, returned value: Error"" );

                                }
    

                                return _feedBack;
                            }


                            public static double GetDouble(string value, double defaultValue)
                            {
                                double result;

                                // Try parsing in the current culture
                                if (!double.TryParse(value.Replace(',', '.'), System.Globalization.NumberStyles.Any, CultureInfo.CurrentCulture, out result)) 
                                {
                                    result = defaultValue;
                                }
                                return result;
                            }


                        }
                    }
                ";


        }

        public string DoInjection(string pCodeToCheck)
        {

            string finalCode = _baseCode.Replace("///injection///", pCodeToCheck);

            finalCode = finalCode.Replace("///injection_definition///", _injection_definition);
            finalCode = finalCode.Replace("///injection_construtor///", _injection_constructor);
            finalCode = finalCode.Replace("///injection_primitives///", _injection_primitives);

            return finalCode;
        }

        public bool CheckSyntax( string pCodeToCheck)
        {
            _compilerOutput = "";
            
            bool syntaxIsOk = false;

            string injection = pCodeToCheck;

            string finalCode = _baseCode.Replace("///injection///", injection);

            finalCode = finalCode.Replace("///injection_definition///", _injection_definition);
            finalCode = finalCode.Replace("///injection_construtor///", _injection_constructor);
            finalCode = finalCode.Replace("///injection_primitives///", _injection_primitives);

            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters();

            parameters.ReferencedAssemblies.Add("System.Drawing.dll");
            parameters.ReferencedAssemblies.Add(@"C:\Users\fil\source\repos\SharedObjects\SharedObjects\bin\Debug\SharedObjects.dll");

            // True - memory generation, false - external file generation
            parameters.GenerateInMemory = true;

            // True - exe file generation, false - dll file generation
            parameters.GenerateExecutable = true;
            
            _compilerResults = provider.CompileAssemblyFromSource(parameters, finalCode);

            if (_compilerResults.Errors.HasErrors)
            {
                StringBuilder sb = new StringBuilder();

                foreach (CompilerError error in _compilerResults.Errors)
                {
                    sb.AppendLine(String.Format("P2 Script Compiler : Error ({0}): {1}", error.ErrorNumber, error.ErrorText));
                }

                _compilerOutput = sb.ToString();
            }
            else
            {
                _compilerOutput = "Script tested successfully.";
                syntaxIsOk = true;
            }

            return syntaxIsOk;

        }


        public bool PreCompileScript(string pCodeToCheck)
        {
            _precompileReady = false;
            _runOutput = "";

            if (CheckSyntax(pCodeToCheck))
            {
                Assembly assembly = _compilerResults.CompiledAssembly;
                Type program = assembly.GetType("DynamicCompiler.Program");
                _main = program.GetMethod("Eval");
                _precompileReady = true;
            }

            return true;
        }

        public bool RunPrecompiledScript(CCellMatrix pTheMatrix)
        {
                if (_precompileReady)
                {
                    try
                    {
                        string sInfo = (string)_main.Invoke(null, new object[] { pTheMatrix });
                        _runOutput = sInfo.ToString() ;
                    }
                    catch (System.Reflection.TargetInvocationException ) //SharedObjects.InvalidFieldException e)
                    {


                    
                    }

                }
                return true;
            
        }



    }



}


