//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\SMART\Documents\Visual Studio 2012\Projects\topecs\topec3_2\topec3_2\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace topec3_2 {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="MyGrammerParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public interface IMyGrammerListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProgram([NotNull] MyGrammerParser.ProgramContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.program"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProgram([NotNull] MyGrammerParser.ProgramContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.declarlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclarlist([NotNull] MyGrammerParser.DeclarlistContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.declarlist"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclarlist([NotNull] MyGrammerParser.DeclarlistContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterIfStatement([NotNull] MyGrammerParser.IfStatementContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.ifStatement"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitIfStatement([NotNull] MyGrammerParser.IfStatementContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.declar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclar([NotNull] MyGrammerParser.DeclarContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.declar"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclar([NotNull] MyGrammerParser.DeclarContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.declar2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDeclar2([NotNull] MyGrammerParser.Declar2Context context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.declar2"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDeclar2([NotNull] MyGrammerParser.Declar2Context context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterCondition([NotNull] MyGrammerParser.ConditionContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.condition"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitCondition([NotNull] MyGrammerParser.ConditionContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterStatements([NotNull] MyGrammerParser.StatementsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.statements"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitStatements([NotNull] MyGrammerParser.StatementsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.prints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterPrints([NotNull] MyGrammerParser.PrintsContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.prints"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitPrints([NotNull] MyGrammerParser.PrintsContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterExpr([NotNull] MyGrammerParser.ExprContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.expr"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitExpr([NotNull] MyGrammerParser.ExprContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterTerm([NotNull] MyGrammerParser.TermContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.term"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitTerm([NotNull] MyGrammerParser.TermContext context);

	/// <summary>
	/// Enter a parse tree produced by <see cref="MyGrammerParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFactor([NotNull] MyGrammerParser.FactorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.factor"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFactor([NotNull] MyGrammerParser.FactorContext context);
}
} // namespace topec3_2
