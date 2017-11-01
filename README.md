# 20171101_csharp

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

- value (stack) og reference typer (heap) (se (billede)[https://github.com/devcronberg/20171101_csharp/blob/master/ReadMe/CSHSHJ-32-1-live.png] fra WhiteBoard)
- brug int (heltal), decimal (kommatal), DateTime (dato/tid), bool (true/false)
- brug ToString med formateringskoder for at formatere tal og datoer
- brug evt konstanter (const)  
- typekonvertering (implicit / explicit) - brug System.Convert ved explicit (eller checked)
- enumerations erstatter en tabel over værdier med logiske navne (farver, ugedage mv)
- struct giver mulighed for sammensatte datatyper (på stack = værdier)
- brug af new på struct's tildeler default værdier til felter

