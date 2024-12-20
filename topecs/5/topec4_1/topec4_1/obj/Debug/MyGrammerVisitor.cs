//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\SMART\Documents\Visual Studio 2012\Projects\topec4_1\topec4_1\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace topec4_1 {
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="MyGrammerParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMyGrammerVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitProgram([NotNull] MyGrammerParser.ProgramContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.statement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitStatement([NotNull] MyGrammerParser.StatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.variableDeclaration"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariableDeclaration([NotNull] MyGrammerParser.VariableDeclarationContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.variable"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVariable([NotNull] MyGrammerParser.VariableContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitIfStatement([NotNull] MyGrammerParser.IfStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.elseStat"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitElseStat([NotNull] MyGrammerParser.ElseStatContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.block"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitBlock([NotNull] MyGrammerParser.BlockContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.printStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitPrintStatement([NotNull] MyGrammerParser.PrintStatementContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.comparisonExpression"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitComparisonExpression([NotNull] MyGrammerParser.ComparisonExpressionContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitExpr([NotNull] MyGrammerParser.ExprContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitTerm([NotNull] MyGrammerParser.TermContext context);

	/// <summary>
	/// Visit a parse tree produced by <see cref="MyGrammerParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFactor([NotNull] MyGrammerParser.FactorContext context);
}
} // namespace topec4_1
