using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Antlr4.Runtime;
using Antlr4.Runtime.Tree;
namespace topec3_1
{
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
