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

    public class VariableInfo
    {
        public string Type { get; set; }  // "int" أو "double"
        public double? Value { get; set; }

        public VariableInfo(string type, double? value)
        {
            Type = type;
            Value = value;
        }
    }

    class MyGrammarVisitor : MyGrammerBaseVisitor<double?>
    {
        // القاموس لتخزين المتغيرات مع نوعها وقيمتها
        private Dictionary<string, VariableInfo> variables = new Dictionary<string, VariableInfo>();

        // دالة لاسترجاع المتغيرات
        public Dictionary<string, VariableInfo> GetVariables()
        {
            return variables;
        }

        // زيارة التصريح الأول (firstDecl)
        public override double? VisitFirstDecl(MyGrammerParser.FirstDeclContext context)
        {
            string varName = context.ID().GetText();
            double? value = null;

            if (variables.ContainsKey(varName))
            {
                throw new Exception("Error: Variable " + varName + " is already defined.");
            }

            // التحقق من النوع (int أو double)
            string type = context.INT() != null ? "int" : "double";

            if (context.expr() != null)
            {
                value = Visit(context.expr());

                // التحقق من أن متغيرات int لا تأخذ قيم double
                if (type == "int" && value != Math.Floor(value.Value))
                {
                    throw new Exception("Error: Cannot assign double value to an int variable.");
                }
            }

            // إضافة المتغير إلى القاموس مع النوع والقيمة
            variables[varName] = new VariableInfo(type, value);
            return null;
        }

        // زيارة التصريح الثاني (decler2)
        public override double? VisitDecler2(MyGrammerParser.Decler2Context context)
        {
            string varName = context.ID().GetText();
            double? value = null;

            if (variables.ContainsKey(varName))
            {
                throw new Exception("Error: Variable " + varName + " is already defined.");
            }

            // التحقق من النوع (int أو double)
            string type = context.INT() != null ? "int" : "double";

            if (context.expr() != null)
            {
                value = Visit(context.expr());

                // التحقق من أن متغيرات int لا تأخذ قيم double
                if (type == "int" && value != Math.Floor(value.Value))
                {
                    throw new Exception("Error: Cannot assign double value to an int variable.");
                }
            }

            // إضافة المتغير إلى القاموس مع النوع والقيمة
            variables[varName] = new VariableInfo(type, value);
            return null;
        }

        // زيارة التعبير (expr)
        public override double? VisitExpr(MyGrammerParser.ExprContext context)
        {
            if (context.PLUS() != null)
            {
                return Visit(context.expr()) + Visit(context.term());
            }
            else if (context.MINUS() != null)
            {
                return Visit(context.expr()) - Visit(context.term());
            }

            return Visit(context.term());
        }

        // زيارة العمليات الحسابية (term)
        public override double? VisitTerm(MyGrammerParser.TermContext context)
        {
            if (context.MUL() != null)
            {
                return Visit(context.term()) * Visit(context.factor());
            }
            else if (context.DIV() != null)
            {
                return Visit(context.term()) / Visit(context.factor());
            }

            return Visit(context.factor());
        }

        // زيارة العوامل (factor)
        public override double? VisitFactor(MyGrammerParser.FactorContext context)
        {
            if (context.NUMBER() != null)
            {
                // قراءة الرقم كـ double لدعم كل من int و double
                return double.Parse(context.NUMBER().GetText());
            }
            else if (context.LIFT() != null)
            {
                return Visit(context.expr());
            }
            else if (context.ID() != null)
            {
                string varName = context.ID().GetText();

                if (variables.ContainsKey(varName))
                {
                    if (variables[varName].Value != null)
                    {
                        return variables[varName].Value;
                    }
                    else
                    {
                        throw new Exception("Error: Variable " + varName + " value is null.");
                    }
                }
                else
                {
                    throw new Exception("Error: Variable " + varName + " is not defined yet.");
                }
            }

            throw new Exception("Invalid factor encountered");
        }
    }

}

