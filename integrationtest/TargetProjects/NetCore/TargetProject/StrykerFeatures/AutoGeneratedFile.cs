//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TargetProject
{
    public class Csharp8
    {
        // these methods should not be mutated
        public static string RockPaperScissors(string first, string second) => (first, second) switch
        {
            ("rock", "paper") => 1 > 2 ? "rock is covered by paper. Paper wins." : "",
            (_, _) => "tie"
        };

        public void SwitchExpression()
        {
            _ = ("rock", "paper") switch
            {
                ("rock", "paper") => RockPaperScissors("", ""),
                (_, _) => "tie"
            };
        }
    }

    public class CSharp7
    {
        public double GetDefault()
        {
            return default;
        }
    }

    public class EndlessLoop
    {
        public void SomeLoop()
        {
            while (1 < 0)
            {
                ;
            }
        }
    }
}