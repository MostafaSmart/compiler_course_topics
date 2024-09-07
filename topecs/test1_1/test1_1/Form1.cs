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


namespace test1_1
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
                IParseTree tree = parser.prog();


                MyGrammerVisitor1 visitor = new MyGrammerVisitor1(textBox2);
                visitor.Visit(tree);

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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


            errorTextBox.AppendText(" line : " + line + "possotisn : " + charPositionInLine+" \n");


        }



    }






    public class MyGrammerVisitor1 : MyGrammerBaseVisitor<object>
{
    private TextBox outputTextBox;

    public MyGrammerVisitor1(TextBox textBox)
    {
        outputTextBox = textBox;
    }

    public override object VisitExpr(MyGrammerParser.ExprContext context)
    {
        try
        {
            string leftNumber = context.NUMBER(0).GetText();
            string rightNumber = context.NUMBER(1).GetText();
            string operatorText = context.oprit().GetText();


            outputTextBox.AppendText("number : " + leftNumber + " \n");
            outputTextBox.AppendText("opritor :" + operatorText + " \n");
            outputTextBox.AppendText("number : " + rightNumber + "\n\n");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message.ToString());
        }


        return null; 
    }

    public override object VisitProg(MyGrammerParser.ProgContext context)
    {

        try
        {
            foreach (var exprContext in context.expr())
            {
                Visit(exprContext);
            }
        }
        catch (Exception ex) {
            MessageBox.Show(ex.Message.ToString());
        }
     
        return null;
    }
}








    public class MyGrammerVisitor2 : MyGrammerBaseVisitor<double>
    {
        public override double VisitExpr(MyGrammerParser.ExprContext context)
        {
            double left = double.Parse(context.NUMBER(0).GetText());
            double right = double.Parse(context.NUMBER(1).GetText());
            string operatorText = context.oprit().GetText();

            switch (operatorText)
            {
                case "+":
                    return left + right;
                case "-":
                    return left - right;
                case "*":
                    return left * right;
                case "/":
                    return left / right;
                default:
                    throw new InvalidOperationException("Unknown operator: " + operatorText);
            }
        }

        public override double VisitProg(MyGrammerParser.ProgContext context)
        {
            double result = 0;
            foreach (var exprContext in context.expr())
            {
                result += Visit(exprContext);
            }
            return result;
        }
    }


}
