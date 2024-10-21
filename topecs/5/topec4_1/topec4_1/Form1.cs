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

namespace topec4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                string input = textBox1.Text.ToString();

                AntlrInputStream inputStreem = new AntlrInputStream(input);

                MyGrammerLexer lexer = new MyGrammerLexer(inputStreem);


                CommonTokenStream lTS = new CommonTokenStream(lexer);

                MyGrammerParser parser = new MyGrammerParser(lTS);

                textBox2.Clear();
                parser.RemoveErrorListeners();

                parser.AddErrorListener(new MyErrorListener(textBox2));


                parser.BuildParseTree = true;
                IParseTree tree = parser.program();
                MyGrammerVisitor visitor = new MyGrammerVisitor(textBox2);
                visitor.Visit(tree);

            }
        }

    


    }




    public class MyErrorListener : BaseErrorListener
    {

        TextBox errorTextBox;

        public MyErrorListener(TextBox _textBox)
        {
            errorTextBox = _textBox;

        }

        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {


            errorTextBox.AppendText(msg + " line : " + line + " possotisn : " + charPositionInLine + " \n");


        }



    }

}