using System.Globalization;
using System.Windows;
using System.Windows.Controls;

namespace Matrix
{
    public partial class MainWindow : Window
    {

        #region Factory and Singleton DP Classes

        public abstract class Result
        {
            public string SyntaxString { get; internal set; }
            public string ResultType { get; internal set; }
            public string OperationString { get; internal set; }

            public abstract void CreatResult();
        }
        
        public class Rb1 : Result
        {
            static Rb1 instance;
            public static Result Instance { get => instance; }
            static Rb1()
            {
                instance = new Rb1();
            }
            public Rb1()
            {
                CreatResult();
            }
            public override void CreatResult()
            {                  
                SyntaxString = "isInvertible = matrix1.HasInverse;";
                ResultType = "Boolean";
                OperationString = "Checking if matrix1 is invertible";
            }
        }      
        public class Rb2 : Result
        {
            static Rb2 instance;
            public static Result Instance { get => instance; }
            static Rb2()
            {
                instance = new Rb2();
            }
            public Rb2()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Translate(offsetX, offsetY);";
                ResultType = "Void";
                OperationString = "Translating a Matrix by a Point";
            }
        }
        public class Rb3 : Result
        {
            static Rb3 instance;
            public static Result Instance { get => instance; }
            static Rb3()
            {
                instance = new Rb3();
            }
            public Rb3()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.TranslatePrepend(offsetX, offsetY);";
                ResultType = "Void";
                OperationString = "Prepending Translating a matrix";
            }
        }
        public class Rb4 : Result
        {
            static Rb4 instance;
            public static Result Instance { get => instance; }
            static Rb4()
            {
                instance = new Rb4();
            }
            public Rb4()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.SetIdentity();";
                ResultType = "Void";
                OperationString = "Setting a matrix to an identity matrix";
            }
        }
        public class Rb5 : Result
        {
            static Rb5 instance;
            public static Result Instance { get => instance; }
            static Rb5()
            {
                instance = new Rb5();
            }
            public Rb5()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "isIdentityMatrix = matrix1.IsIdentity;";
                ResultType = "Boolean";
                OperationString = "Determining if a Matrix is an identity matrix";
            }
        }
        public class Rb6 : Result
        {
            static Rb6 instance;
            public static Result Instance { get => instance; }
            static Rb6()
            {
                instance = new Rb6();
            }
            public Rb6()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1 = Matrix.Identity;";
                ResultType = "Matrix";
                OperationString = "Gets an identity Matrix";
            }
        }
        public class Rb7 : Result
        {
            static Rb7 instance;
            public static Result Instance { get => instance; }
            static Rb7()
            {
                instance = new Rb7();
            }
            public Rb7()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrixResult = Matrix.Parse(\"1,2,3,4,5,6\");";
                ResultType = "Matrix";
                OperationString = "Convert a string into a Matrix structure";
            }
        }
        public class Rb8 : Result
        {
            static Rb8 instance;
            public static Result Instance { get => instance; }
            static Rb8()
            {
                instance = new Rb8();
            }
            public Rb8()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "areEqual = Matrix.Equals(matrix1, matrix2);";
                ResultType = "Boolean";
                OperationString = "Checking if the matrices are equal";
            }
        }
        public class Rb8b : Result
        {
            static Rb8b instance;
            public static Result Instance { get => instance; }
            static Rb8b()
            {
                instance = new Rb8b();
            }
            public Rb8b()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "areEqual = Matrix.Equals(matrix1, matrix2);";
                ResultType = "Boolean";
                OperationString = "Checking if the matrices are equal";
            }
        }
        public class Rb9 : Result
        {
            static Rb9 instance;
            public static Result Instance { get => instance; }
            static Rb9()
            {
                instance = new Rb9();
            }
            public Rb9()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "areEqual = matrix1 == matrix2;";
                ResultType = "Boolean";
                OperationString = "Checking if the matrices are equal";
            }
        }
        public class Rb10 : Result
        {
            static Rb10 instance;
            public static Result Instance { get => instance; }
            static Rb10()
            {
                instance = new Rb10();
            }
            public Rb10()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "areEqual = matrix1 != matrix2;";
                ResultType = "Boolean";
                OperationString = "Checking if the matrices are not equal";
            }
        }
        public class Rb11 : Result
        {
            static Rb11 instance;
            public static Result Instance { get => instance; }
            static Rb11()
            {
                instance = new Rb11();
            }
            public Rb11()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Invert();";
                ResultType = "Void";
                OperationString = "Inverting a matrix";
            }
        }
        public class Rb12 : Result
        {
            static Rb12 instance;
            public static Result Instance { get => instance; }
            static Rb12()
            {
                instance = new Rb12();
            }
            public Rb12()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Prepend(matrix2);";
                ResultType = "Void";
                OperationString = "Prepending a Matrix to another Matrix";
            }
        }
        public class Rb13 : Result
        {
            static Rb13 instance;
            public static Result Instance { get => instance; }
            static Rb13()
            {
                instance = new Rb13();
            }
            public Rb13()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Append(matrix2);";
                ResultType = "Void";
                OperationString = "Appending a Matrix to another Matrix";
            }
        }
        public class Rb14 : Result
        {
            static Rb14 instance;
            public static Result Instance { get => instance; }
            static Rb14()
            {
                instance = new Rb14();
            }
            public Rb14()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Rotate(rotateAngle);";
                ResultType = "Void";
                OperationString = "Rotating a Matrix";
            }
        }
        public class Rb15 : Result
        {
            static Rb15 instance;
            public static Result Instance { get => instance; }
            static Rb15()
            {
                instance = new Rb15();
            }
            public Rb15()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.RotateAt(rotateAngle, rotateCenterX, rotateCenterY);";
                ResultType = "Void";
                OperationString = "Rotating a Matrix";
            }
        }
        public class Rb16 : Result
        {
            static Rb16 instance;
            public static Result Instance { get => instance; }
            static Rb16()
            {
                instance = new Rb16();
            }
            public Rb16()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.RotatePrepend(rotateAngle);";
                ResultType = "Void";
                OperationString = "Rotating a Matrix";
            }
        }
        public class Rb17 : Result
        {
            static Rb17 instance;
            public static Result Instance { get => instance; }
            static Rb17()
            {
                instance = new Rb17();
            }
            public Rb17()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.RotateAtPrepend(rotateAngle, rotateCenterX, rotateCenterY);";
                ResultType = "Void";
                OperationString = "Rotating a Matrix";
            }
        }
        public class Rb18 : Result
        {
            static Rb18 instance;
            public static Result Instance { get => instance; }
            static Rb18()
            {
                instance = new Rb18();
            }
            public Rb18()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Scale(scaleX, scaleY);";
                ResultType = "Void";
                OperationString = "Scaling a Matrix";
            }
        }
        public class Rb19 : Result
        {
            static Rb19 instance;
            public static Result Instance { get => instance; }
            static Rb19()
            {
                instance = new Rb19();
            }
            public Rb19()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrixResult = Matrix.Multiply(matrix2, matrix1);";
                ResultType = "Matrix";
                OperationString = "Multiplying matrix1 and matrix2";
            }
        }
        public class Rb20 : Result
        {
            static Rb20 instance;
            public static Result Instance { get => instance; }
            static Rb20()
            {
                instance = new Rb20();
            }
            public Rb20()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = " matrixResult = matrix1 * matrix2;";
                ResultType = "Matrix";
                OperationString = "Multiplying matrix1 and matrix2";
            }
        }
        public class Rb21 : Result
        {
            static Rb21 instance;
            public static Result Instance { get => instance; }
            static Rb21()
            {
                instance = new Rb21();
            }
            public Rb21()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Skew(skewAngleX, skewAngleY);";
                ResultType = "Void";
                OperationString = "Multiplying matrix2 and matrix1";
            }
        }
        public class Rb22 : Result
        {
            static Rb22 instance;
            public static Result Instance { get => instance; }
            static Rb22()
            {
                instance = new Rb22();
            }
            public Rb22()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.SkewPrepend(skewAngleX, skewAngleY);";
                ResultType = "Void";
                OperationString = "Multiplying matrix2 and matrix1";
            }
        }
        public class Rb23 : Result
        {
            static Rb23 instance;
            public static Result Instance { get => instance; }
            static Rb23()
            {
                instance = new Rb23();
            }
            public Rb23()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Scale(scaleFactorX, scaleFactorY);";
                ResultType = "Void";
                OperationString = "Appending a scale to a matrix";
            }
        }
        public class Rb24 : Result
        {
            static Rb24 instance;
            public static Result Instance { get => instance; }
            static Rb24()
            {
                instance = new Rb24();
            }
            public Rb24()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = " matrix1.ScaleAt(scaleFactorX, scaleFactorY, scaleCenterX, scaleCenterY);";
                ResultType = "Void";
                OperationString = "Appends a scale at a specific point to matrix1";
            }
        }
        public class Rb25 : Result
        {
            static Rb25 instance;
            public static Result Instance { get => instance; }
            static Rb25()
            {
                instance = new Rb25();
            }
            public Rb25()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.ScalePrepend(scaleFactorX, scaleFactorY);";
                ResultType = "Void";
                OperationString = "Prepending a scale to matrix1";
            }
        }
        public class Rb26 : Result
        {
            static Rb26 instance;
            public static Result Instance { get => instance; }
            static Rb26()
            {
                instance = new Rb26();
            }
            public Rb26()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.ScalePrependAt(scaleFactorX, scaleFactorY, centerPointX, centerPointY);";
                ResultType = "Void";
                OperationString = "Prepending a scale at a specific point to matrix1";
            }
        }
        public class Rb29 : Result
        {
            static Rb29 instance;
            public static Result Instance { get => instance; }
            static Rb29()
            {
                instance = new Rb29();
            }
            public Rb29()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "pointResult = matrix1.Transform(point1)";
                ResultType = "Point";
                OperationString = "Transforming a point1 by matrix1";
            }
        }
        public class Rb30 : Result
        {
            static Rb30 instance;
            public static Result Instance { get => instance; }
            static Rb30()
            {
                instance = new Rb30();
            }
            public Rb30()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "vectorResult = matrix1.Transform(vector1);";
                ResultType = "Vector";
                OperationString = "Multiplying matrix2 and matrix1";
            }
        }
        public class Rb31 : Result
        {
            static Rb31 instance;
            public static Result Instance { get => instance; }
            static Rb31()
            {
                instance = new Rb31();
            }
            public Rb31()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = "matrix1.Transform(pointArray);";
                ResultType = "void";
                OperationString = "Transforming an array of Points by matrix1";
            }
        }
        public class Rb32 : Result
        {
            static Rb32 instance;
            public static Result Instance { get => instance; }
            static Rb32()
            {
                instance = new Rb32();
            }
            public Rb32()
            {
                CreatResult();
            }
            public override void CreatResult()
            {
                SyntaxString = " matrix1.Transform(vectorArray);";
                ResultType = "Void";
                OperationString = "Multiplying matrix2 and matrix1";
            }
        }
        
        public enum types
        {
            Rb1, Rb2, Rb3, Rb4, Rb5, Rb6, Rb7, Rb8, Rb8b, Rb9, Rb10, Rb11, Rb12, Rb13, Rb14, Rb15, Rb16, Rb17, Rb18, Rb19, Rb20,
            Rb21, Rb22, Rb23, Rb24, Rb25, Rb26, Rb29, Rb30, Rb31, Rb32
        }

        public class Creater
        {
            public Result FactoryMethod(types resultType)
            {
                Result result = null;
                switch (resultType)
                {
                    case types.Rb1:
                        result = Rb1.Instance;
                        break;                        
                    case types.Rb2:
                        result = Rb2.Instance;
                        break;
                    case types.Rb3:
                        result = Rb3.Instance;
                        break;
                    case types.Rb4:
                        result = Rb4.Instance;
                        break;
                    case types.Rb5:
                        result = Rb5.Instance;
                        break;
                    case types.Rb6:
                        result = Rb6.Instance;
                        break;
                    case types.Rb7:
                        result = Rb7.Instance;
                        break;
                    case types.Rb8:
                        result = Rb8.Instance;
                        break;
                    case types.Rb8b:
                        result = Rb8b.Instance;
                        break;
                    case types.Rb9:
                        result = Rb9.Instance;
                        break;
                    case types.Rb10:
                        result = Rb10.Instance;
                        break;
                    case types.Rb11:
                        result = Rb11.Instance;
                        break;
                    case types.Rb12:
                        result = Rb12.Instance;
                        break;
                    case types.Rb13:
                        result = Rb13.Instance;
                        break;
                    case types.Rb14:
                        result = Rb14.Instance;
                        break;
                    case types.Rb15:
                        result = Rb15.Instance;
                        break;
                    case types.Rb16:
                        result = Rb16.Instance;
                        break;
                    case types.Rb17:
                        result = Rb17.Instance;
                        break;
                    case types.Rb18:
                        result = Rb18.Instance;
                        break;
                    case types.Rb19:
                        result = Rb19.Instance;
                        break;
                    case types.Rb20:
                        result = Rb20.Instance;
                        break;
                    case types.Rb21:
                        result = Rb21.Instance;
                        break;
                    case types.Rb22:
                        result = Rb22.Instance;
                        break;
                    case types.Rb23:
                        result = Rb23.Instance;
                        break;
                    case types.Rb24:
                        result = Rb24.Instance;
                        break;
                    case types.Rb25:
                        result = Rb25.Instance;
                        break;
                    case types.Rb26:
                        result = Rb26.Instance;
                        break;
                    case types.Rb29:
                        result = Rb29.Instance;
                        break;
                    case types.Rb30:
                        result = Rb30.Instance;
                        break;
                    case types.Rb31:
                        result = Rb31.Instance;
                        break;
                    case types.Rb32:
                        result = Rb32.Instance;
                        break;
                }
                return result;
            }
        }

        #endregion

        #region Facade DP Classes

        class Vars
        {
            public Point p1;
            public Vector v1;
            public System.Windows.Media.Matrix m1,m2;
            public double s1;
            
            public void CreatVars()
            {
                p1 = new P1().CreatP1();
                v1 = new V1().CreatV1();
                m1 = new M1().CreatM1();
                m2 = new M2().CreatM2();
                s1 = new S1().CreatS1();
            }
        }

        class P1
        {
            public Point CreatP1()
            {
                return new Point(15, 25);
            }
        }
        class V1
        {
            public Vector CreatV1()
            {
                return new Vector(15, 25);
            }
        }
        class M1
        {
            public System.Windows.Media.Matrix CreatM1()
            {
                return new System.Windows.Media.Matrix(5, 10, 15, 20, 25, 30);
            }
        }
        class M2
        {
            public System.Windows.Media.Matrix CreatM2()
            {
                return new System.Windows.Media.Matrix(2, 4, 6, 8, 10, 12);
            }
        }
        class S1
        {
            public double CreatS1()
            {
                return 75;
            }
        }

        #endregion

        #region Command DP Classes

        public class Transactions
        {
            public System.Windows.Media.Matrix CreatMatrix1()
            {
                return new System.Windows.Media.Matrix(5, 10, 15, 20, 25, 30);
            }
            public System.Windows.Media.Matrix CreatMatrix2()
            {
                return new System.Windows.Media.Matrix(2, 4, 6, 8, 10, 12);

            }
        }

        public interface ICommand
        {
            System.Windows.Media.Matrix Run();
        }

        public class CommandCreatMatrix1 : ICommand
        {
            private Transactions transactions;
            
            public CommandCreatMatrix1(Transactions _transactions)
            {
                transactions = _transactions;
            } 

            public System.Windows.Media.Matrix Run()
            {
                return transactions.CreatMatrix1();
            }
        }

        public class CommandCreatMatrix2 : ICommand
        {
            private Transactions transactions;

            public CommandCreatMatrix2(Transactions _transactions)
            {
                transactions = _transactions;
            }

            public System.Windows.Media.Matrix Run()
            {
                return transactions.CreatMatrix2();
            }
        }

        public class DatabaseCommandForwarder
        {
            public System.Windows.Media.Matrix Run(ICommand command)
            {
                return command.Run();
            }
        }

        #endregion

        #region Adapter DP Classes
        
        class Client
        {
            string text;

            public string Text { get => text; set => text = value; }

            public Client()
            {
                CreatText();
            }

            public virtual void CreatText()
            {
                Text = "Welcome";
            }
        }

        class NewTexts
        {
            public string Text1()
            {
                return "Welcome To Matrix Example,";
            }

            public string Text2()
            {
                return "\nThis Program Explains The Basic Rules For Matrices With Examples";
            }
        }

        class Adapter : Client
        {
            public NewTexts _newTexts = new NewTexts();

            public Adapter()
            {
                CreatText();
            }

            public override void CreatText()
            {
                Text = _newTexts.Text1();
                Text += _newTexts.Text2();
            }
        }

        #endregion

        public MainWindow()
        {
            InitializeComponent();
            Show();
            ShowVars();

            Client c = new Adapter();
            Title.Content = c.Text;
        }

        public void PerformOperation(object sender, RoutedEventArgs e)
        {
            var li = sender as RadioButton;

            CommandCreatMatrix1 commandCreatMatrix1 = new CommandCreatMatrix1(new Transactions());
            CommandCreatMatrix2 commandCreatMatrix2 = new CommandCreatMatrix2(new Transactions());
            DatabaseCommandForwarder databaseCommandForwarder = new DatabaseCommandForwarder();

            switch (li?.Name)
            {
                case "rb1":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    
                    var isInvertible = matrix1.HasInverse;

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb1);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb2":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    
                    const double offsetX = 15;
                    const double offsetY = 25;
                    matrix1.Translate(offsetX, offsetY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb2);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb3":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    
                    const double offsetX = 15;
                    const double offsetY = 25;

                    matrix1.TranslatePrepend(offsetX, offsetY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb3);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb4":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    matrix1.SetIdentity();

                   Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb4);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb5":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    
                    matrix1.SetIdentity();

                    var isIdentityMatrix = matrix1.IsIdentity;

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb5);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb6":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);  
                        
                    matrix1 = System.Windows.Media.Matrix.Identity;

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb6);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb7":
                {
                    var matrixResult = new System.Windows.Media.Matrix();

                    matrixResult = System.Windows.Media.Matrix.Parse("1,2,3,4,5,6");

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb7);
                    ShowResults(matrixResult.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb8":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);  
                        
                    var areEqual = System.Windows.Media.Matrix.Equals(matrix1, matrix2);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb8);
                    ShowResults(areEqual.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb8b":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    var areEqual = matrix1.Equals(matrix2);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb8b);
                    ShowResults(areEqual.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb9":
                { 
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    var areEqual = matrix1 == matrix2;

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb9);
                    ShowResults(areEqual.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb10":
                {  
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    var areEqual = matrix1 != matrix2;

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb10);
                    ShowResults(areEqual.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb11":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    if (matrix1.HasInverse)
                    {
                        matrix1.Invert();
                    }

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb11);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb12":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    matrix1.Prepend(matrix2);
                    
                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb12);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb13":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    matrix1.Append(matrix2);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb13);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb14":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double rotateAngle = 90;

                    matrix1.Rotate(rotateAngle);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb14);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb15":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    matrix1.RotateAt(90, 2, 4);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb15);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb16":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double rotateAngle = 90;
                    matrix1.RotatePrepend(rotateAngle);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb16);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb17":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    matrix1.RotateAtPrepend(90, 2, 4);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb17);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb18":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double scaleX = (1);
                    double scaleY = (2);

                    matrix1.Scale(scaleX, scaleY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb18);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb19":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    var matrixResult = new System.Windows.Media.Matrix();

                    matrixResult = System.Windows.Media.Matrix.Multiply(matrix2, matrix1);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb19);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb20":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   
                    var matrix2 = databaseCommandForwarder.Run(commandCreatMatrix2);

                    var matrixResult = new System.Windows.Media.Matrix();

                    matrixResult = matrix1*matrix2;

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb20);
                    ShowResults(matrixResult.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb21":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double skewAngleX = 45;
                    double skewAngleY = 180;
                    matrix1.Skew(skewAngleX, skewAngleY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb21);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb22":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double skewAngleX = 45;
                    double skewAngleY = 180;
                    matrix1.SkewPrepend(skewAngleX, skewAngleY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb22);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb23":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double scaleFactorX = 2;
                    double scaleFactorY = 4;
                    matrix1.Scale(scaleFactorX, scaleFactorY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb23);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb24":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    matrix1.ScaleAt(2, 4, 5, 10);

                   Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb24);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb25":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    double scaleFactorX = 2;
                    double scaleFactorY = 4;
                    matrix1.ScalePrepend(scaleFactorX, scaleFactorY);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb25);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb26":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    matrix1.ScaleAtPrepend(2, 4, 5, 10);
                    
                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb26);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb29":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    var point1 = new Point(15, 25);
                    var pointResult = new Point();

                    pointResult = matrix1.Transform(point1);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb29);
                    ShowResults(pointResult.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb30":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    var vector1 = new Vector(15, 25);
                    new Vector();

                    matrix1.Transform(vector1);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb30);
                    ShowResults(matrix1.ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb31":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    var pointArray = new Point[2];

                    pointArray[0].X = 15;
                    pointArray[0].Y = 25;
                    pointArray[1].X = 30;
                    pointArray[1].Y = 35;

                    matrix1.Transform(pointArray);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb31);
                    ShowResults(pointArray[1].ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
                case "rb32":
                {
                    var matrix1 = databaseCommandForwarder.Run(commandCreatMatrix1);                   

                    var vectorArray = new Vector[2];

                    vectorArray[0].X = 15;
                    vectorArray[0].Y = 25;
                    vectorArray[1].X = 30;
                    vectorArray[1].Y = 35;

                    matrix1.Transform(vectorArray);

                    Creater creater = new Creater();
                    Result result = creater.FactoryMethod(types.Rb32);
                    ShowResults(vectorArray[0].ToString(), result.SyntaxString, result.ResultType, result.OperationString);
                    break;
                }
            }
        }

        private void ShowResults(string resultValue, string syntax, string resultType, string opString)
        {
            txtResultValue.Text = resultValue;
            txtSyntax.Text = syntax;
            txtResultType.Text = resultType;
            txtOperation.Text = opString;
        }

        public void ShowVars()
        {   
            var facade = new Vars();
            facade.CreatVars();

            txtPoint1.Text = facade.p1.ToString();
            txtVector1.Text = facade.v1.ToString();
            txtMatrix1.Text = facade.m1.ToString();
            txtMatrix2.Text = facade.m2.ToString();
            txtScalar1.Text = facade.s1.ToString(CultureInfo.InvariantCulture);
        }
    }
}