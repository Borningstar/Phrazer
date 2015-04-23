using System;
using System.Collections.Generic;

namespace Phrazer
{
	public static class Phrases
	{
		static Phrase whoWins = new Phrase(WhoWins());

		public static string getWhoWins(){
			return whoWins.generatePhrase();
		}

		static Phrase explainToMe = new Phrase(ExplainToMe());

		public static string getExplainToMe(){
			return explainToMe.generatePhrase();
		}

		static Dictionary<string, Dictionary<string, List<string>>> WhoWins(){
			List<string> modifiers = new List<string>{"giant", "tiny", "supersonic", "robotic", "mecha", "My Little", "magical", "Nazi", "demon", "mecha Nazi", "hippie", "Barbie Princess", "Crazy-Ass", "Gargantuan", "undead", "zombie", "Lord of the Dance", "Super Sayian", "sensual", "transvestite", "gigantic", "He-Who-Must-Not-Be-Named", "radical", "eco-friendly", "squirrel expert", "pixelated", "narcoleptic", "preschool", "sleazy", "Dr.", "ninja"};
			List<string> fighters = new List<string>{"Batman", "Superman", "Jesus", "God", "Godzilla", "Charizard", "Pikachu", "Ghandi", "Hitler", "Osama Bin Laden", "Saddam Hussein", "Tarzan", "Kim Jom Il", "Chuck Norris", "Bruce Lee", "Bruce Willis", "Captain Planet", "Vegeta", "Abe Lincoln", "Goku", "GlaDoS", "Steve Jobs", "Bill Gates", "Obama", "Jack Sparrow", "Legolas", "Gimli", "Big Bird", "Harry Potter", "Voldemort", "Barbie", "Donkey Kong", "Mario", "Master Chief", "Michael Jackson", "Julia Gillard", "Vegeta", "Sherlock Holmes" };
			List<string> weapons = new List<string>{ "a cat", "a mouse", "a dog", "a helicopter", "magical powers", "a ballerina troupe", "a gazeebo", "weapons of mass destruction", "an orbital death fortress", "unicorns", "a sock", "the KKK", "a baby", "wingardium leviosa", "the Mafia", "voodoo magic", "the Kraken", "the Black Pearl", "armageddon", "babies", "breakdancing", "baristas", "a utility belt", "a power level of over 9000", "a roundhouse kick", "the power of ten thousand suns", "boobs", "a bacon weave", "an axe", "a sword", "a bow", "a catapult", "the apocalypse", "zombies", "penguins", "the Llama Tactical Strike Force", "portals", "mind control", "sporks", "an army of cyborgs", "a horde of hamsters", "an AK47", "the fusion dance", "a spirit bomb" };

			Dictionary<string, Dictionary<string, List<string>>> whoWins = new Dictionary<string, Dictionary<string, List<string>>>
			{
				{ "start", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {"If "} }, 
						{ "nextWord", new List<string> {"modifier", "fighter"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "modifier", new Dictionary<string, List<string>> { 
						{ "wordList", modifiers}, 
						{ "nextWord", new List<string> {"postModSpace"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "postModSpace", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" "} }, 
						{ "nextWord", new List<string> {"fighter"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "fighter", new Dictionary<string, List<string>> { 
						{ "wordList", fighters}, 
						{ "nextWord", new List<string> {"noWeapon", "usedWeapon"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "noWeapon", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" fought "} }, 
						{ "nextWord", new List<string> {"fighter2", "modifier2"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "usedWeapon", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" used "} }, 
						{ "nextWord", new List<string> {"weapon"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "weapon", new Dictionary<string, List<string>> { 
						{ "wordList", weapons }, 
						{ "nextWord", new List<string> {"postWeapon"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "postWeapon", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" to fight "} }, 
						{ "nextWord", new List<string> {"fighter2"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "modifier2", new Dictionary<string, List<string>> { 
						{ "wordList", modifiers}, 
						{ "nextWord", new List<string> {"postModSpace2"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "postModSpace2", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" "} }, 
						{ "nextWord", new List<string> {"fighter2"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "fighter2", new Dictionary<string, List<string>> { 
						{ "wordList", fighters }, 
						{ "nextWord", new List<string> {"finish"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "finish", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" then who would win?"} }, 
						{ "nextWord", new List<string> {""} }, 
						{ "styles", new List<string> {} }
					} 
				}
			};

			return whoWins;
		}

		static Dictionary<string, Dictionary<string, List<string>>> ExplainToMe(){
			List<string> characters = new List<string>{"a hipster", "the Batman", "the Joker", "Justin", "Superman", "Jesus", "God", "Ghandi", "Hitler", "Osama Bin Laden", "Saddam Hussein", "Tarzan", "Kim Jom Il", "Chuck Norris", "Bruce Lee", "Bruce Willis", "Captain Planet", "Vegeta", "Abe Lincoln", "Goku", "GlaDoS", "Steve Jobs", "Bill Gates", "Obama", "Jack Sparrow", "Legolas", "Gimli", "Big Bird", "Harry Potter", "Voldemort", "Donkey Kong", "Mario", "Master Chief", "Michael Jackson", "Julia Gillard", "Vegeta", "Sherlock Holmes", "a hard boiled-detective", "a misogynistic college student", "a 2nd grader", "a stereotypical stoned surfer dude from a 1980s comedy", "a YouTube thread", "Abraham Lincoln", "a total frat bro", "an overly hormonal pre-teen girl", "a Soviet communist", "a mad scientist", "a robot", "Samuel L. Jackson", "a skydiver at 10,000 ft above sea level and your parachute refuses to open", "a rebellious teenager", "Bill Cosby", "a stripper", "Michael Cera", "Ramsay Bolton", "Professor Oak", "a James Bond style Supervillan", "the last Tsar of Russia", "the Frankenstein monster", "Tywin Lannister", "Daenaerys Targaryen"};
			List<string> statusMe = new List<string>{"and I don't realise that I'm a hipster", "and I don't realise that I'm the Batman", "and I'm not wearing any pants", "and I've just threatened to marry your sister", "except I don't realise that I'm Justin", "and I'm on fire but don't notice", "and I'm deaf", "and I'm nearsighted", "and I'm your father", "and I'm your mother", "and I'm from the past", "and I'm from the future", "and I'm a hard boiled detective", "and I'm in a noir crime novel", "and I've gotten drunk for the first time", "and I'm about to get laid", "and I'm every character played by Michael Cera", "and I'm a hardcore rapper", "and I'm  n extremely confident, yet extremely incompetent mouth harp player", "and I'm the villain of a musical", "and I'm your prisoner", "and I'm drunk at karaoke and didn't want to relenquish the microphone", "and I have a small caliber pistol gently touching your testicles, fully loaded", "and I'm fleeing from an angry mob", "and I'm gay", "and I'm engorged", "and I'm horny", "and I'm trapped in your sex dungeon"};
			List<string> statusUs = new List<string>{"both don't realise we're hipsters", "both don't realise we're the Batman", "both trying to be the Batman", "both hate Justin", "magnetically attracted to each other", "both doctors", "both in a noir crime novel", "we've gotten drunk for the first time", "we're about to get laid", "we're fleeing from an angry mob", "we're in a romantic comedy", "we're in an action movie", "we're conjoined twins"};
			List<string> statusYou = new List<string>{"don't realise you're a hipster", " don't realise you're the Batman", "'re on fire", "'re pretending to be Justin", " can only speak really high pitched", " can only speak really low pitched", "'re on the phone", " can only speak very fast", " can only speak very slowly", "'re in a noir crime novel", "'ve gotten drunk for the first time", "'re about to get laid", "'re every character played by Michael Cera", "'re an extremely confident, yet extremely incompetent mouth harp player", "'re the villain of a musical", "'re my prisoner", "'re drunk at karaoke and didn't want to relenquish the microphone", "'re recovering from a long night of hookers, booze, and cocaine", "'re fleeing from an angry mob", "'re gay", "'re drunk", "a poet", "'re enraged", "'re engorged", "'re horny", " can only speak in riddles", " can't use vowels", "'re hand is possessed"};
			List<string> topics = new List<string>{"hipsters", "Chaos Theory", "how cars work", "what a clown is", "how to make a sandwich", "what a tree is", "the human condition", "how to sex", "the unwritten rules of the playground", "why you have a beer in your hand", "the history of the Soviet Union", "why I should let you break the Prime Directive", "how eagles mate", "the storyline of Half-Life", "what life is like in a frat house", "your prowess in bed", "religion", "Munchkin", "Star Trek", "why your home state is superior in every conceivable way", "your decision to quit the band and go solo", "the Geneva Convention", "the Transgender Community", "the nature of good and evil"
				};

			Dictionary<string, Dictionary<string, List<string>>> whoWins = new Dictionary<string, Dictionary<string, List<string>>>
			{
				{ "start", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {"Explain to me "} }, 
						{ "nextWord", new List<string> {"topic"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "topic", new Dictionary<string, List<string>> { 
						{ "wordList", topics }, 
						{ "nextWord", new List<string> {"youCharacterStart"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "youCharacterStart", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" like you're "} }, 
						{ "nextWord", new List<string> {"youCharacter"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "youCharacter", new Dictionary<string, List<string>> { 
						{ "wordList", characters }, 
						{ "nextWord", new List<string> {"youStatusStart", "meStatusStart", "meCharacterStart", "usStatusStart", "finish"} }, 
						{ "styles", new List<string> {} }
					} 
				},
					//You Status//
					{ "youStatusStart", new Dictionary<string, List<string>> { 
							{ "wordList", new List<string> {" and you "} }, 
							{ "nextWord", new List<string> {"youStatus"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					{ "youStatus", new Dictionary<string, List<string>> { 
							{ "wordList", statusYou }, 
							{ "nextWord", new List<string> {"finish"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					//***//
					//Us Status//
					{ "usStatusStart", new Dictionary<string, List<string>> { 
							{ "wordList", new List<string> {" .And we're "} }, 
							{ "nextWord", new List<string> {"usStatus"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					{ "usStatus", new Dictionary<string, List<string>> { 
							{ "wordList", statusUs }, 
							{ "nextWord", new List<string> {"finish"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					//***//
					//Me character//
					{ "meCharacterStart", new Dictionary<string, List<string>> { 
							{ "wordList", new List<string> {" .And I'm "} }, 
							{ "nextWord", new List<string> {"meCharacter"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					{ "meCharacter", new Dictionary<string, List<string>> { 
							{ "wordList", characters }, 
							{ "nextWord", new List<string> {"finish", "meStatusStart2", "usStatusStart2"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					//***//
						//Me status 2//
						{ "meStatusStart2", new Dictionary<string, List<string>> { 
								{ "wordList", new List<string> {" and I'm "} }, 
								{ "nextWord", new List<string> {"meStatus2"} }, 
								{ "styles", new List<string> {} }
							} 
						},
						{ "meStatus2", new Dictionary<string, List<string>> { 
								{ "wordList", statusMe }, 
								{ "nextWord", new List<string> {"finish"} }, 
								{ "styles", new List<string> {} }
							} 
						},
						//***//
					//Me status//
					{ "meStatusStart", new Dictionary<string, List<string>> { 
							{ "wordList", new List<string> {" .And I'm "} }, 
							{ "nextWord", new List<string> {"meStatus"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					{ "meStatus", new Dictionary<string, List<string>> { 
							{ "wordList", statusMe }, 
							{ "nextWord", new List<string> {"usStatusStart2", "finish"} }, 
							{ "styles", new List<string> {} }
						} 
					},
					//***//
				//Us Status 2//
				{ "usStatusStart2", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {" and we're "} }, 
						{ "nextWord", new List<string> {"usStatus"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				{ "usStatus2", new Dictionary<string, List<string>> { 
						{ "wordList", statusUs }, 
						{ "nextWord", new List<string> {"finish"} }, 
						{ "styles", new List<string> {} }
					} 
				},
				//***//
				{ "finish", new Dictionary<string, List<string>> { 
						{ "wordList", new List<String> { "." } }, 
						{ "nextWord", new List<string> {""} }, 
						{ "styles", new List<string> {} }
					} 
				},
					
			};

			return whoWins;
		}

	}
}

