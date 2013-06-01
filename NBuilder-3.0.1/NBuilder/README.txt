== NBUILDER'S NEW SYNTAX - Version 3.0 ==

After taking feedback from some developers, I realised that the way the syntax differed between 
building a single object and a list of objects had been a bad decision.

The old method names:

WhereTheFirst(), WhereTheLast(), Have(), etc

Have been replaced with:

TheFirst(), TheLast(), With()

I have made the old methods obsolete to encourage people to use the new syntax.

Realising that this may annoy people who don't want to have to go through and change all the calls, 
I decided to make the obsoleting of them conditional. If you don't want them to appear obsolete, then use
the build under "Build_that_does_not_obsolete_old_syntax". The code is completely identical but the [Obsolete] 
attributes are hidden using #if pre-processor directives

However I would urge people to switch to the new syntax.