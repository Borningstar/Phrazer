using System;
using System.Collections.Generic;

namespace Phrazer
{
	public class Phrase
	{
		Dictionary<string, Dictionary<string, List<string>>> phraseModel;
		Random rnd = new Random();

		public Phrase(Dictionary<string, Dictionary<string, List<string>>> phrase){
			phraseModel = phrase;
		}

		public string getWord(string listName){
			return phraseModel [listName]["wordList"][rnd.Next(0, phraseModel[listName]["wordList"].Count)];
		}

		public string getNext(string listName){
			return phraseModel [listName]["nextWord"][rnd.Next(0, phraseModel[listName]["nextWord"].Count)];
		}

		public string generatePhrase(){
			string current = "start";
			string next = this.getNext (current);
			string phrase = this.getWord (current);
			int loops = 0;

			while (next != "" && loops < 200) {
				current = next;
				loops++;
				if (current != "") {
					phrase += this.getWord (current);
					next = this.getNext (current);
				} else {
					break;
				}
			}
			return phrase;
		}			
	}
}

