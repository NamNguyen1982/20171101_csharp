# 20171101_csharp

02-11 Nåede gennem methods - opgaver med hjem. Summering, gennemgå og fortsæt til 6

## Module 1 Intro
- Forskellige runtimes (.NET Framework, .NET Core, Mono/Xamarin)
- C# -> IL kode -> binær eksekverbar kode
- [Anders Hejlsberg](https://en.wikipedia.org/wiki/Anders_Hejlsberg)
- [VS 2017](https://www.visualstudio.com/)

## Module 2 C#
- scope {}
- er case sensitive
- er white space insensitive
- using = søg automatisk i namespace
- namespace bruges til at struktere kode og undgå navne sammenfald
- System.Console indeholder WriteLine og ReadLine
- Comments (brug // eller ///)
- Use the debugger (breakpoint = F9)
- VS = solution er paraply for projekter
- Brug evt StyleCop for at sikre korrekt navngivning
- Brug evt ILSpy eller dotPeek til at se og konvertere IL kode

## Module 3 Value types

- value (stack) og reference typer (heap) (se [billede](https://github.com/devcronberg/20171101_csharp/blob/master/ReadMe/CSHSHJ-32-1-live.png) fra WhiteBoard)
- brug int (heltal), decimal (kommatal), DateTime (dato/tid), bool (true/false)
- brug ToString med formateringskoder for at formatere tal og datoer
- brug evt konstanter (const)  
- typekonvertering (implicit / explicit) - brug System.Convert ved explicit (eller checked)
- enumerations erstatter en tabel over værdier med logiske navne (farver, ugedage mv)
- struct giver mulighed for sammensatte datatyper (på stack = værdier)
- brug af new på struct's tildeler default værdier til felter

## Module 4 Reference types
- Se eksempel Person... Forskel på struct og class (stack/heap, værdier/referencer)
- Arrays defineres med [] og er ref. baseret
- Brug metoder på System.Array til sortering mv
- string = strenge = immutable (kan ikke ændres efter initialisering)
- er egentlig en ref. type men =, + mv er overloaded for at gøre livet nemmere
- brug IKKE string i løkker (brug System.Text.StringBuilder)
- betingelser = if, switch
- løkker = for, foreach, do, while
- break hopper ud af struktur
- continue hopper til ny iteration

## Module 5 Methods
- Metode signatur = retur type samt parametre
- Værdi baserede variabler som argumenter bliver ikke tilrettet (stack frame)
- Ref baserede variabler som argumenter kan tilrettes (heap)
- Se og forstå eksempler på ovennævnte - kod det gerne selv og brug debugger
- Optional og overloads kan bruges til at have metoder med samme navn der kan kaldes på forskellig måde

## Module 6 Intro OOP
- The Three Pillars of OOP = Encapsulation, Inheritance, Polymorphism
- UML, Gang of four, Martin Fowler
- class + internal/public
- brug af new
- object = ref = var på stack og objekt på heap (visualisér)
- felter = data
- private og offentlige felter (offentlige felter = medarbejdersamtale - brug egenskaber eller metoder)
- default og custom (argumenter) constructor
- brug base til at kæde constructor'er sammen
- partial = klasser med sammen navn der kompileres sammen (i samme assembly)
- indkapsling med metoder (som java - get.. set..)
- forskel på stuct og class (stack/heap, ingen nedarvning/nedarvning)
