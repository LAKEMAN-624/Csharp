!      SAMPLE PROGRAM.  BOX DESIGN.
      PROGRAM EX11
      IMPLICIT DOUBLE PRECISION (A-H,O-Z)
      DIMENSION X(5), XL(5), XU(5), G(5),
     1WK(800), IWK(200), RPRM(20), IPRM(20)
      NRWK=800
      NRIWK=200
      DO 10 I=1,20
          RPRM(I)=0.0
10      IPRM(I)=0
      METHOD=2
      NDV=3
      NCON=1
      DO 20 I=1,NDV
          X(I)=1.0
          XL(I)=0.0
  20    XU(I)=100.0
      IPRINT=1
      MINMAX=-1
      INFO=0
100   CALL DOT(INFO, METHOD, IPRINT, NDV, NCON, X, XL, XU,
     *OBJ, MINMAX, G, RPRM, IPRM, WK, NRWK, IWK, NRIWK)
      IF(INFO.EQ.0)STOP
      CALL EVAL(OBJ,X,G)
      GO TO 100
      END
      
      SUBROUTINE EVAL(OBJ,X,G)
      IMPLICIT DOUBLE PRECISION (A-H,O-Z)
      DIMENSION X(*),G(*)
      OBJ=2.0*X(2)*X(1)+2.0*X(3)*X(1)+4.0*X(2)*X(3)
      G(1)=1.0-0.5*X(1)*X(2)*X(3)
      RETURN
      END