using System;
using System.Collections.Generic;

namespace Phrazer
{
	public class Phrase
	{
		Dictionary<string, Dictionary<string, List<string>>> phraseModel;
		Random rnd = new Random();

		public Phrase(){
			phraseModel = new Dictionary<string, Dictionary<string, List<string>>> {
				{ "start", new Dictionary<string, List<string>> { 
						{ "wordList", new List<string> {} }, 
						{ "nextWord", new List<string> {""} }, 
						{ "styles", new List<string> {} }
					} 
				}
			};
		}

		public Phrase(Dictionary<string, Dictionary<string, List<string>>> phrase){
			phraseModel = phrase;
		}

		public void setStart(List<string> start){
			phraseModel ["start"] ["nextWord"] = start;
		}

		public string getWord(string listName){
			return phraseModel [listName]["wordList"][rnd.Next(0, phraseModel[listName]["wordList"].Count)];
		}

		public string getNext(string listName){
			return phraseModel [listName]["nextWord"][rnd.Next(0, phraseModel[listName]["nextWord"].Count)];
		}

		public List<string> getStyles(string listName){
			return phraseModel [listName] ["styles"];
		}

		public void addPart(string key, List<string> wordList, List<string> nextWord, List<string> styles ){
			Dictionary<string, List<string>> part = new Dictionary<string, List<string>> {
				{"wordList", wordList},
				{"nextWord", nextWord},
				{"styles", styles}
			};
			phraseModel.Add(key, part); 
		}

		public void addPart(string key, Dictionary<string, List<string>> part ){
			phraseModel.Add(key, part); 
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

