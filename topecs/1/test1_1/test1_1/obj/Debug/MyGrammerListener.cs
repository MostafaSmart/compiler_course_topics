//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\SMART\Documents\Visual Studio 2012\Projects\test1_1\test1_1\MyGrammer.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace test1_1 {
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
	/// Enter a parse tree produced by <see cref="MyGrammerParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterProg([NotNull] MyGrammerParser.ProgContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.prog"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitProg([NotNull] MyGrammerParser.ProgContext context);

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
	/// Enter a parse tree produced by <see cref="MyGrammerParser.oprit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterOprit([NotNull] MyGrammerParser.OpritContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="MyGrammerParser.oprit"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitOprit([NotNull] MyGrammerParser.OpritContext context);
}
} // namespace test1_1
