grammar MyGrammer;


/*
 * Lexer Rules
 */


 NUMBER : [0-9]+ ;

 PLUS : '+' ;

 MINUS : '-' ;

 DIV : '/' ;

 MULT : '*' ;

 SIMI : ';' ;

 WS : [ \t\n\r]->skip;

 INVALID : . ;



/*
 * Parser Rules
 */


 prog : expr (SIMI expr)* SIMI EOF ;

 expr : NUMBER oprit NUMBER ;

 oprit : PLUS | MINUS |DIV | MULT ;

