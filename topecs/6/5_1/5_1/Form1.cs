using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
using System.Diagnostics;
using System.IO;

namespace _5_1
{

    
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

       
        }





 
        private void RunParser()
        {
            if (richTextBox1.Text.Length > 0)
            {

             
                string input = richTextBox1.Text;

            
                AntlrInputStream inputStream = new AntlrInputStream(input);
                MyGrammerLexer lexer = new MyGrammerLexer(inputStream);
                CommonTokenStream tokenStream = new CommonTokenStream(lexer);
                MyGrammerParser parser = new MyGrammerParser(tokenStream);

               
                //parser.RemoveErrorListeners();
                //parser.AddErrorListener(new MyErrorListener(richTextBox1));
                string cppFilePath = "C:\\Users\\SMART\\Documents\\Visual Studio 2012\\Projects\\5_1\\5_1\\codeOut.cpp";
                string exeFilePath = "C:\\Users\\SMART\\Documents\\Visual Studio 2012\\Projects\\5_1\\5_1\\generated_code.exe";
                
              parser.BuildParseTree = true;
                IParseTree tree = parser.program();

                MyGrammerVisitor vister = new MyGrammerVisitor();
                vister.Visit(tree);
                vister.SaveCodeToFile(cppFilePath);

                CompileCppToExe(cppFilePath, exeFilePath);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        RunParser();
        }
   

    private void CompileCppToExe(string cppFilePath, string exeFilePath)
    {
      
        Process compileProcess = new Process();
        compileProcess.StartInfo.FileName = "g++";
        compileProcess.StartInfo.Arguments = "-o \"" + exeFilePath + "\" \"" + cppFilePath + "\"";
        compileProcess.StartInfo.RedirectStandardOutput = true;
        compileProcess.StartInfo.RedirectStandardError = true;
        compileProcess.StartInfo.UseShellExecute = false;
        compileProcess.StartInfo.CreateNoWindow = true;

        try
        {
          
            compileProcess.Start();
            string output = compileProcess.StandardOutput.ReadToEnd();
            string errors = compileProcess.StandardError.ReadToEnd();
            compileProcess.WaitForExit();

           
            if (compileProcess.ExitCode == 0)
            {
                textBox1.AppendText("Compilation succeeded! Executable created: " + exeFilePath);
                Process.Start(exeFilePath);

            }
            else
            {
                textBox1.AppendText("Compilation failed:\n" + errors);
            }
        }
        catch (Exception ex)
        {
            textBox1.AppendText("Error while compiling:\n" + ex.Message);
        }
        finally
        {
            compileProcess.Close();
        }
    }
 
    }


 
    //public class MyErrorListener : BaseErrorListener
    //{
    //    private RichTextBox richTextBox;

    //    public MyErrorListener(RichTextBox _richTextBox)
    //    {
    //        richTextBox = _richTextBox;
    //    }

    //    public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
    //    {
    //        int startIndex = offendingSymbol.StartIndex;
    //        int length = offendingSymbol.StopIndex - startIndex + 1;

    //        // تحديد اللون الأحمر تحت النص الذي يحتوي على خطأ
    //        richTextBox.Select(startIndex, length);
    //        richTextBox.SelectionBackColor = Color.Red;

    //        // إعادة تحديد النص بعد الخطأ للون الافتراضي
    //        richTextBox.Select(richTextBox.TextLength, 0);
    //        richTextBox.SelectionBackColor = Color.White;
    //    }
    //}



}
