# Simple C# questions for the Hello World exercise

## Markdown
(Learn more at markdown at https://code.visualstudio.com/Docs/languages/markdown)
To switch between views, press Ctrl+Shift+V in the editor. 
You can view the preview side-by-side (Ctrl+K V) with the file you are editing and see changes reflected in real-time as you edit.

## Questions
- What is the better equavelant of getch/getchar in C#? Read? Readkey? something else? E.g. for the use of certain keys but also just any key press.

## Findings

(https://social.msdn.microsoft.com/Forums/en-US/5515c215-6701-4a05-ba0a-9cd63ef206df/difference-between-readreadline-and-readkey-in-c?forum=csharpgeneral)

Console.ReadLine() Method: Reads the next line of characters from the standard input stream.

   
`string s = Console.ReadLine();    
Console.WriteLine("Your input is {0}.", s);`