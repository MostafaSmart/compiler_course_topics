grammar MyGrammer;

/*
 * Lexer Rules
 */


 INT : 'int';


 ID : [a-zA-Z_] [a-zA-Z_0-9]*;

 NUMBER : [0-9]+;
 
ASSIGNMENT : '=';

 SIMI : ';' ;

 COMA : ',';

 WS      : [ \t\r\n]+ -> skip;

 INVALID : . ;

 

/*
 * Parser Rules
 */


 ////1


 //prog: statement SIMI EOF ;

 //statement : INT ID ASSIGNMENT NUMBER | INT ID ;









 
 ////2


// prog: statement SIMI EOF ;

// statement : decler (COMA decler)* ;

//decler : INT ID ASSIGNMENT NUMBER | INT ID;







 //3

prog: statement SIMI EOF ;

statement : firstDecl (COMA decler2)* ;

firstDecl : INT ID ASSIGNMENT NUMBER
          | INT ID
          ;

decler2 : (INT)? ID ASSIGNMENT NUMBER
       | (INT)? ID
       ;










//prog: (statement SIMI)+ EOF ;

//statement
//    : firstDecl (COMA decler2)* 
//    ;

//firstDecl
//    : INT ID ASSIGNMENT NUMBER 
//    | INT ID                    
//    ;

//decler2
//    : (INT)? ID ASSIGNMENT NUMBER  
//    | (INT)? ID                    
//    ;