using Semplice.Kiriwa.Domains;

namespace Semplice.Kiriwa.DAL.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Semplice.Kiriwa.DAL.Entity.KiriwaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Semplice.Kiriwa.DAL.Entity.KiriwaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.

            var _stack1 = new Stack
            {
                StackId = 1,
                Name = "Improving Enterprise's Powerful Questions",
                Description =
                    "A powerful question puts a halt to evasion and confusion. By asking the powerful question, the coach invites the client to clarity, action and discovery at a whole new level.",
                Created = DateTime.Now
            };
            var _stack2 = new Stack
            {
                StackId = 2,
                Name = "Oblique Strategy",
                Description = "Based on \"The Thoughts Behind the Thoughts\" created by Peter Schmidt in 1970 and \"Oblique Strategies\" by Brian Eno in 1974. The complete set first published in 1975. Each card offers an aphorism intended to help artists (particularly musicians) break creative blocks by encouraging lateral thinking.",
                Created = DateTime.Now
            };

            context.Stacks.AddOrUpdate(new Stack[]
            {
                _stack1,
                _stack2
            });

            context.Cards.AddOrUpdate(new Card[]
            {
                // region Stack 1
                new Card { CardId = 1, FrontTitle = "", FrontText = "What else?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 2, FrontTitle = "", FrontText = "What is at risk?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 3, FrontTitle = "", FrontText = "So what?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 4, FrontTitle = "", FrontText = "What will that get you?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 5, FrontTitle = "", FrontText = "What is your prediction?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 6, FrontTitle = "", FrontText = "What is stopping you?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 7, FrontTitle = "", FrontText = "What part is not yet clear?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 8, FrontTitle = "", FrontText = "Whose opinion matters on this topic?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 9, FrontTitle = "", FrontText = "Who wants you to scceed?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 10, FrontTitle = "", FrontText = "What do you long for?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 11, FrontTitle = "", FrontText = "What might help look like?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 12, FrontTitle = "", FrontText = "How will you know when you have reached it?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 13, FrontTitle = "", FrontText = "What will you think of this five years from now?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 14, FrontTitle = "", FrontText = "How could you improve the situation?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 15, FrontTitle = "", FrontText = "What resources do you need to help you decide?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 16, FrontTitle = "", FrontText = "If you got it, what would you have?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 17, FrontTitle = "", FrontText = "How does it look to you?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 18, FrontTitle = "", FrontText = "What's already working that you can build on?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 19, FrontTitle = "", FrontText = "What part is [confusing] [surprising] [annoying] [etc]?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 20, FrontTitle = "", FrontText = "What other angles can you think of?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 21, FrontTitle = "", FrontText = "What's the [worst] [best] that could happen?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 22, FrontTitle = "", FrontText = "What would an experiment look like?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 23, FrontTitle = "", FrontText = "What would a simpler way look like?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 24, FrontTitle = "", FrontText = "What is important about that?", Stack = _stack1, Created = DateTime.Now },
                
                // region Stack 2
                new Card { CardId = 25, FrontTitle = "", FrontText = "A line has two sides.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 26, FrontTitle = "", FrontText = "A very small object -Its centre.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 27, FrontTitle = "", FrontText = "Abandon desire.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 28, FrontTitle = "", FrontText = "Abandon normal instructions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 29, FrontTitle = "", FrontText = "Accretion.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 30, FrontTitle = "", FrontText = "Adding on.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 31, FrontTitle = "", FrontText = "Always first steps.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 32, FrontTitle = "", FrontText = "Always give yourself credit for having more than personality.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 33, FrontTitle = "", FrontText = "Always the first steps.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 34, FrontTitle = "", FrontText = "Are there sections? Consider transitions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 35, FrontTitle = "", FrontText = "Ask people to work against their better judgement.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 36, FrontTitle = "", FrontText = "Ask your body.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 37, FrontTitle = "", FrontText = "Back up a few steps. What else could you have done?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 38, FrontTitle = "", FrontText = "Be dirty.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 39, FrontTitle = "", FrontText = "Be extravagant.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 40, FrontTitle = "", FrontText = "Be less critical more often.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 41, FrontTitle = "", FrontText = "Breathe more deeply.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 42, FrontTitle = "", FrontText = "Bridges -build -burn.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 43, FrontTitle = "", FrontText = "Call your mother and ask her what to do.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 44, FrontTitle = "", FrontText = "Cascades.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 45, FrontTitle = "", FrontText = "Change instrument roles.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 46, FrontTitle = "", FrontText = "Change nothing and continue with immaculate consistency.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 47, FrontTitle = "", FrontText = "Change specifics to ambiguities.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 48, FrontTitle = "", FrontText = "Children's voices -speaking -singing.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 49, FrontTitle = "", FrontText = "Cluster analysis.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 50, FrontTitle = "", FrontText = "Consider different fading systems.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 51, FrontTitle = "", FrontText = "Consider transitions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 52, FrontTitle = "", FrontText = "Consult other sources -promising -unpromising.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 53, FrontTitle = "", FrontText = "Convert a melodic element into a rhythmic element.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 54, FrontTitle = "", FrontText = "Courage!", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 55, FrontTitle = "", FrontText = "Cut a vital connection.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 56, FrontTitle = "", FrontText = "Decorate, decorate.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 57, FrontTitle = "", FrontText = "Define an area as `safe' and use it as an anchor.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 58, FrontTitle = "", FrontText = "Describe the landscape in which this belongs. (9 August).", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 59, FrontTitle = "", FrontText = "Destroy nothing; Destroy the most important thing.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 60, FrontTitle = "", FrontText = "Discard an axiom.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 61, FrontTitle = "", FrontText = "Disciplined self-indulgence.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 62, FrontTitle = "", FrontText = "Disconnect from desire.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 63, FrontTitle = "", FrontText = "Discover the recipes you are using and abandon them.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 64, FrontTitle = "", FrontText = "Discover your formulas and abandon them.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 65, FrontTitle = "", FrontText = "Display your talent.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 66, FrontTitle = "", FrontText = "Distorting time.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 67, FrontTitle = "", FrontText = "Do something boring.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 68, FrontTitle = "", FrontText = "Do the last thing first.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 69, FrontTitle = "", FrontText = "Do the washing up.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 70, FrontTitle = "", FrontText = "Do the words need changing?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 71, FrontTitle = "", FrontText = "Do we need holes?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 72, FrontTitle = "", FrontText = "Don't avoid what is easy.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 73, FrontTitle = "", FrontText = "Don't be afraid of things because they're easy to do.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 74, FrontTitle = "", FrontText = "Don't be frightened of cliches.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 75, FrontTitle = "", FrontText = "Don't be frightened to display your talents.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 76, FrontTitle = "", FrontText = "Don't break the silence.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 77, FrontTitle = "", FrontText = "Don't stress one thing more than another.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 78, FrontTitle = "", FrontText = "Emphasize differences.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 79, FrontTitle = "", FrontText = "Emphasize repetitions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 80, FrontTitle = "", FrontText = "Emphasize the flaws.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 81, FrontTitle = "", FrontText = "Feed the recording back out of the medium.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 82, FrontTitle = "", FrontText = "Feedback recordings into an acoustic situation.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 83, FrontTitle = "", FrontText = "Fill every beat with something.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 84, FrontTitle = "", FrontText = "First work alone, then work in unusual pairs.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 85, FrontTitle = "", FrontText = "Get your neck massaged.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 86, FrontTitle = "", FrontText = "Ghost echoes.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 87, FrontTitle = "", FrontText = "Give the game away.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 88, FrontTitle = "", FrontText = "Give way to your worst impulse.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 89, FrontTitle = "", FrontText = "Go outside. Shut the door.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 90, FrontTitle = "", FrontText = "How would someone else do it?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 91, FrontTitle = "", FrontText = "How would you explain this to your parents?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 92, FrontTitle = "", FrontText = "How would you have done it?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 93, FrontTitle = "", FrontText = "Idiot glee (?)", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 94, FrontTitle = "", FrontText = "Imagine the music as a moving chain or caterpillar.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 95, FrontTitle = "", FrontText = "Imagine the music as a series of disconnected events.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 96, FrontTitle = "", FrontText = "Infinitesimal gradations.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 97, FrontTitle = "", FrontText = "Intentions -credibility of -nobility of -humility of.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 98, FrontTitle = "", FrontText = "Is it finished?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 99, FrontTitle = "", FrontText = "Is something missing?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 100, FrontTitle = "", FrontText = "Is the style right?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 101, FrontTitle = "", FrontText = "Is the tuning appropriate?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 102, FrontTitle = "", FrontText = "Is the tuning intonation correct?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 103, FrontTitle = "", FrontText = "It is quite possible (after all).", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 104, FrontTitle = "", FrontText = "It is simply a matter or work.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 105, FrontTitle = "", FrontText = "Left channel, right channel, centre channel.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 106, FrontTitle = "", FrontText = "List the qualities it has. List those you'd like.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 107, FrontTitle = "", FrontText = "Listen in total darkness, or in a very large room, very quietly.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 108, FrontTitle = "", FrontText = "Listen to the quiet voice.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 109, FrontTitle = "", FrontText = "Look at a very small object, look at its centre.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 110, FrontTitle = "", FrontText = "Look at the order in which you do things.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 111, FrontTitle = "", FrontText = "Look closely at the most embarrassing details and amplify.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 112, FrontTitle = "", FrontText = "Lost in useless territory.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 113, FrontTitle = "", FrontText = "Lowest common denominator check -single beat -single note -single riff.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 114, FrontTitle = "", FrontText = "Magnify the most difficult details.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 115, FrontTitle = "", FrontText = "Make a blank valuable by putting it in an excquisite frame.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 116, FrontTitle = "", FrontText = "Make what's perfect more human.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 117, FrontTitle = "", FrontText = "Mechanize something idiosyncratic.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 118, FrontTitle = "", FrontText = "Move towards the unimportant.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 119, FrontTitle = "", FrontText = "Mute and continue.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 120, FrontTitle = "", FrontText = "Not building a wall but making a brick.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 121, FrontTitle = "", FrontText = "Once the search has begun, something will be found.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 122, FrontTitle = "", FrontText = "Only a part, not the whole.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 123, FrontTitle = "", FrontText = "Only one element of each kind.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 124, FrontTitle = "", FrontText = "Overtly resist change.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 125, FrontTitle = "", FrontText = "Pae White's non-blank graphic metacard.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 126, FrontTitle = "", FrontText = "Pay attention to distractions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 127, FrontTitle = "", FrontText = "Put in earplugs.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 128, FrontTitle = "", FrontText = "Question the heroic approach.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 129, FrontTitle = "", FrontText = "Remember those quiet evenings.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 130, FrontTitle = "", FrontText = "Remove a restriction.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 131, FrontTitle = "", FrontText = "Remove specifics and convert to ambiguities.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 132, FrontTitle = "", FrontText = "Remove the middle, extend the edges.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 133, FrontTitle = "", FrontText = "Repetition is a form of change.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 134, FrontTitle = "", FrontText = "Retrace your steps.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 135, FrontTitle = "", FrontText = "Reverse.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 136, FrontTitle = "", FrontText = "Short circuit (example; a man eating peas with the idea that they will improve his virility shovels them straight into his lap).", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 137, FrontTitle = "", FrontText = "Shut the door and listen from outside.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 138, FrontTitle = "", FrontText = "Simple subtraction.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 139, FrontTitle = "", FrontText = "Slow preparation, fast execution.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 140, FrontTitle = "", FrontText = "Spectrum analysis.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 141, FrontTitle = "", FrontText = "State the problem in words as simply as possible.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 142, FrontTitle = "", FrontText = "Steal a solution.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 143, FrontTitle = "", FrontText = "Take a break.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 144, FrontTitle = "", FrontText = "Take away as much mystery as possible. What is left?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 145, FrontTitle = "", FrontText = "Take away the elements in order of apparent non-importance.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 146, FrontTitle = "", FrontText = "Tape your mouth.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 147, FrontTitle = "", FrontText = "The inconsistency principle.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 148, FrontTitle = "", FrontText = "The most important thing is the thing most easily forgotten.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 149, FrontTitle = "", FrontText = "The tape is now the music.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 150, FrontTitle = "", FrontText = "Think - inside the work -outside the work.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 151, FrontTitle = "", FrontText = "Tidy up.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 152, FrontTitle = "", FrontText = "Try faking it.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 153, FrontTitle = "", FrontText = "Twist the spine.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 154, FrontTitle = "", FrontText = "Use \"unqualified\" people.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 155, FrontTitle = "", FrontText = "Use an old idea.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 156, FrontTitle = "", FrontText = "Use an unacceptable color.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 157, FrontTitle = "", FrontText = "Use fewer notes.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 158, FrontTitle = "", FrontText = "Use your own ideas.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 159, FrontTitle = "", FrontText = "Voice your suspicions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 160, FrontTitle = "", FrontText = "Water.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 161, FrontTitle = "", FrontText = "What are the sections sections of? Imagine a caterpillar moving.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 162, FrontTitle = "", FrontText = "What do you do? Now, what do you do best?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 163, FrontTitle = "", FrontText = "What else is this like?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 164, FrontTitle = "", FrontText = "What is the reality of the situation?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 165, FrontTitle = "", FrontText = "What is the simplest solution?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 166, FrontTitle = "", FrontText = "What most recently impressed you? How is it similar? What can you learn from it? What could you take from it?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 167, FrontTitle = "", FrontText = "What to increase? What to reduce? What to maintain?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 168, FrontTitle = "", FrontText = "What were you really thinking about just now? Incorporate.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 169, FrontTitle = "", FrontText = "What would your closest friend do?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 170, FrontTitle = "", FrontText = "What wouldn't you do?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 171, FrontTitle = "", FrontText = "When is it for? Who is it for?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 172, FrontTitle = "", FrontText = "Where is the edge?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 173, FrontTitle = "", FrontText = "Which parts can be grouped?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 174, FrontTitle = "", FrontText = "Work at a different speed.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 175, FrontTitle = "", FrontText = "You can only make one dot at a time.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 176, FrontTitle = "", FrontText = "Your mistake was a hidden intention.", Stack = _stack2, Created = DateTime.Now }
            });
        }
    }
}
