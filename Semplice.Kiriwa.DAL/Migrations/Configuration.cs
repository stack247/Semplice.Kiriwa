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
                new Card { CardId = 1, Title = "", Text = "What else?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 2, Title = "", Text = "What is at risk?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 3, Title = "", Text = "So what?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 4, Title = "", Text = "What will that get you?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 5, Title = "", Text = "What is your prediction?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 6, Title = "", Text = "What is stopping you?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 7, Title = "", Text = "What part is not yet clear?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 8, Title = "", Text = "Whose opinion matters on this topic?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 9, Title = "", Text = "Who wants you to scceed?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 10, Title = "", Text = "What do you long for?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 11, Title = "", Text = "What might help look like?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 12, Title = "", Text = "How will you know when you have reached it?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 13, Title = "", Text = "What will you think of this five years from now?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 14, Title = "", Text = "How could you improve the situation?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 15, Title = "", Text = "What resources do you need to help you decide?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 16, Title = "", Text = "If you got it, what would you have?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 17, Title = "", Text = "How does it look to you?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 18, Title = "", Text = "What's already working that you can build on?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 19, Title = "", Text = "What part is [confusing] [surprising] [annoying] [etc]?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 20, Title = "", Text = "What other angles can you think of?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 21, Title = "", Text = "What's the [worst] [best] that could happen?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 22, Title = "", Text = "What would an experiment look like?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 23, Title = "", Text = "What would a simpler way look like?", Stack = _stack1, Created = DateTime.Now },
                new Card { CardId = 24, Title = "", Text = "What is important about that?", Stack = _stack1, Created = DateTime.Now },
                
                // region Stack 2
                new Card { CardId = 25, Title = "", Text = "A line has two sides.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 26, Title = "", Text = "A very small object -Its centre.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 27, Title = "", Text = "Abandon desire.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 28, Title = "", Text = "Abandon normal instructions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 29, Title = "", Text = "Accretion.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 30, Title = "", Text = "Adding on.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 31, Title = "", Text = "Always first steps.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 32, Title = "", Text = "Always give yourself credit for having more than personality.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 33, Title = "", Text = "Always the first steps.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 34, Title = "", Text = "Are there sections? Consider transitions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 35, Title = "", Text = "Ask people to work against their better judgement.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 36, Title = "", Text = "Ask your body.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 37, Title = "", Text = "Back up a few steps. What else could you have done?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 38, Title = "", Text = "Be dirty.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 39, Title = "", Text = "Be extravagant.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 40, Title = "", Text = "Be less critical more often.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 41, Title = "", Text = "Breathe more deeply.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 42, Title = "", Text = "Bridges -build -burn.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 43, Title = "", Text = "Call your mother and ask her what to do.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 44, Title = "", Text = "Cascades.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 45, Title = "", Text = "Change instrument roles.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 46, Title = "", Text = "Change nothing and continue with immaculate consistency.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 47, Title = "", Text = "Change specifics to ambiguities.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 48, Title = "", Text = "Children's voices -speaking -singing.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 49, Title = "", Text = "Cluster analysis.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 50, Title = "", Text = "Consider different fading systems.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 51, Title = "", Text = "Consider transitions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 52, Title = "", Text = "Consult other sources -promising -unpromising.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 53, Title = "", Text = "Convert a melodic element into a rhythmic element.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 54, Title = "", Text = "Courage!", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 55, Title = "", Text = "Cut a vital connection.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 56, Title = "", Text = "Decorate, decorate.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 57, Title = "", Text = "Define an area as `safe' and use it as an anchor.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 58, Title = "", Text = "Describe the landscape in which this belongs. (9 August).", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 59, Title = "", Text = "Destroy nothing; Destroy the most important thing.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 60, Title = "", Text = "Discard an axiom.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 61, Title = "", Text = "Disciplined self-indulgence.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 62, Title = "", Text = "Disconnect from desire.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 63, Title = "", Text = "Discover the recipes you are using and abandon them.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 64, Title = "", Text = "Discover your formulas and abandon them.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 65, Title = "", Text = "Display your talent.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 66, Title = "", Text = "Distorting time.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 67, Title = "", Text = "Do something boring.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 68, Title = "", Text = "Do the last thing first.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 69, Title = "", Text = "Do the washing up.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 70, Title = "", Text = "Do the words need changing?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 71, Title = "", Text = "Do we need holes?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 72, Title = "", Text = "Don't avoid what is easy.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 73, Title = "", Text = "Don't be afraid of things because they're easy to do.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 74, Title = "", Text = "Don't be frightened of cliches.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 75, Title = "", Text = "Don't be frightened to display your talents.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 76, Title = "", Text = "Don't break the silence.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 77, Title = "", Text = "Don't stress one thing more than another.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 78, Title = "", Text = "Emphasize differences.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 79, Title = "", Text = "Emphasize repetitions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 80, Title = "", Text = "Emphasize the flaws.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 81, Title = "", Text = "Feed the recording back out of the medium.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 82, Title = "", Text = "Feedback recordings into an acoustic situation.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 83, Title = "", Text = "Fill every beat with something.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 84, Title = "", Text = "First work alone, then work in unusual pairs.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 85, Title = "", Text = "Get your neck massaged.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 86, Title = "", Text = "Ghost echoes.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 87, Title = "", Text = "Give the game away.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 88, Title = "", Text = "Give way to your worst impulse.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 89, Title = "", Text = "Go outside. Shut the door.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 90, Title = "", Text = "How would someone else do it?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 91, Title = "", Text = "How would you explain this to your parents?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 92, Title = "", Text = "How would you have done it?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 93, Title = "", Text = "Idiot glee (?)", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 94, Title = "", Text = "Imagine the music as a moving chain or caterpillar.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 95, Title = "", Text = "Imagine the music as a series of disconnected events.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 96, Title = "", Text = "Infinitesimal gradations.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 97, Title = "", Text = "Intentions -credibility of -nobility of -humility of.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 98, Title = "", Text = "Is it finished?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 99, Title = "", Text = "Is something missing?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 100, Title = "", Text = "Is the style right?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 101, Title = "", Text = "Is the tuning appropriate?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 102, Title = "", Text = "Is the tuning intonation correct?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 103, Title = "", Text = "It is quite possible (after all).", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 104, Title = "", Text = "It is simply a matter or work.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 105, Title = "", Text = "Left channel, right channel, centre channel.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 106, Title = "", Text = "List the qualities it has. List those you'd like.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 107, Title = "", Text = "Listen in total darkness, or in a very large room, very quietly.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 108, Title = "", Text = "Listen to the quiet voice.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 109, Title = "", Text = "Look at a very small object, look at its centre.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 110, Title = "", Text = "Look at the order in which you do things.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 111, Title = "", Text = "Look closely at the most embarrassing details and amplify.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 112, Title = "", Text = "Lost in useless territory.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 113, Title = "", Text = "Lowest common denominator check -single beat -single note -single riff.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 114, Title = "", Text = "Magnify the most difficult details.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 115, Title = "", Text = "Make a blank valuable by putting it in an excquisite frame.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 116, Title = "", Text = "Make what's perfect more human.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 117, Title = "", Text = "Mechanize something idiosyncratic.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 118, Title = "", Text = "Move towards the unimportant.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 119, Title = "", Text = "Mute and continue.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 120, Title = "", Text = "Not building a wall but making a brick.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 121, Title = "", Text = "Once the search has begun, something will be found.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 122, Title = "", Text = "Only a part, not the whole.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 123, Title = "", Text = "Only one element of each kind.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 124, Title = "", Text = "Overtly resist change.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 125, Title = "", Text = "Pae White's non-blank graphic metacard.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 126, Title = "", Text = "Pay attention to distractions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 127, Title = "", Text = "Put in earplugs.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 128, Title = "", Text = "Question the heroic approach.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 129, Title = "", Text = "Remember those quiet evenings.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 130, Title = "", Text = "Remove a restriction.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 131, Title = "", Text = "Remove specifics and convert to ambiguities.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 132, Title = "", Text = "Remove the middle, extend the edges.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 133, Title = "", Text = "Repetition is a form of change.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 134, Title = "", Text = "Retrace your steps.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 135, Title = "", Text = "Reverse.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 136, Title = "", Text = "Short circuit (example; a man eating peas with the idea that they will improve his virility shovels them straight into his lap).", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 137, Title = "", Text = "Shut the door and listen from outside.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 138, Title = "", Text = "Simple subtraction.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 139, Title = "", Text = "Slow preparation, fast execution.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 140, Title = "", Text = "Spectrum analysis.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 141, Title = "", Text = "State the problem in words as simply as possible.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 142, Title = "", Text = "Steal a solution.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 143, Title = "", Text = "Take a break.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 144, Title = "", Text = "Take away as much mystery as possible. What is left?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 145, Title = "", Text = "Take away the elements in order of apparent non-importance.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 146, Title = "", Text = "Tape your mouth.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 147, Title = "", Text = "The inconsistency principle.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 148, Title = "", Text = "The most important thing is the thing most easily forgotten.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 149, Title = "", Text = "The tape is now the music.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 150, Title = "", Text = "Think - inside the work -outside the work.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 151, Title = "", Text = "Tidy up.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 152, Title = "", Text = "Try faking it.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 153, Title = "", Text = "Twist the spine.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 154, Title = "", Text = "Use \"unqualified\" people.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 155, Title = "", Text = "Use an old idea.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 156, Title = "", Text = "Use an unacceptable color.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 157, Title = "", Text = "Use fewer notes.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 158, Title = "", Text = "Use your own ideas.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 159, Title = "", Text = "Voice your suspicions.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 160, Title = "", Text = "Water.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 161, Title = "", Text = "What are the sections sections of? Imagine a caterpillar moving.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 162, Title = "", Text = "What do you do? Now, what do you do best?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 163, Title = "", Text = "What else is this like?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 164, Title = "", Text = "What is the reality of the situation?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 165, Title = "", Text = "What is the simplest solution?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 166, Title = "", Text = "What most recently impressed you? How is it similar? What can you learn from it? What could you take from it?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 167, Title = "", Text = "What to increase? What to reduce? What to maintain?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 168, Title = "", Text = "What were you really thinking about just now? Incorporate.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 169, Title = "", Text = "What would your closest friend do?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 170, Title = "", Text = "What wouldn't you do?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 171, Title = "", Text = "When is it for? Who is it for?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 172, Title = "", Text = "Where is the edge?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 173, Title = "", Text = "Which parts can be grouped?", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 174, Title = "", Text = "Work at a different speed.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 175, Title = "", Text = "You can only make one dot at a time.", Stack = _stack2, Created = DateTime.Now },
                new Card { CardId = 176, Title = "", Text = "Your mistake was a hidden intention.", Stack = _stack2, Created = DateTime.Now }
            });
        }
    }
}
