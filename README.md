# DefineConstantsSandbox
DefineConstantsでどこまでできるのか

```
chmod u+x ./run.sh 1
chmod u+X ./run.sh 2
```

## Result
```
---------------
- /p:DevNum=1 -
---------------
---------------
-    DEBUG    -
---------------
Program Start (Debug)
/p:DevNum=? detected!
Dog is true

MyClass#Print Called!
DEBUG env connecting...
DEV1 env connected!

---------------
-   RELEASE   -
---------------
Program Start (Release)
/p:DevNum=? detected!

MyClass#Print Called!
RELEASE env connected!

---------------
- /p:DevNum=2 -
---------------
---------------
-    DEBUG    -
---------------
Program Start (Debug)
/p:DevNum=? detected!
CAT is true

MyClass#Print Called!
DEBUG env connecting...
DEV2 env connected!

---------------
-   RELEASE   -
---------------
Program Start (Release)
/p:DevNum=? detected!

MyClass#Print Called!
RELEASE env connected!
```
