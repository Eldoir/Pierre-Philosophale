using Newtonsoft.Json;
using System.Collections.Generic;

/* http://mitchkeenan.com/cardproxy/ */
/*  Fields with the key 'title' will be bold and larger.
 *  Fields with the key 'flavor' will be italic and smaller.
 *  If a field with the key 'count' is present it will be ignored and if it's a number then many duplicates of the card will be made.
 */

namespace Pierre_Philosophale
{
    public class FileData
    {
        public List<Card> cards;

        public FileData()
        {
            cards = new List<Card>();
        }

        public void AddCard(Card c)
        {
            cards.Add(c);
        }
    }

    public class Card
    {
        public string title;
        public string alignment;
        public string flavor;
        public string action;
        public string effects;
        public string notes;
        public int count;

        public Card(string title = "", string alignment = "", string flavor = "", string action = "", string effects = "", string notes = "", int count = 1)
        {
            this.title = title;
            this.alignment = alignment;
            this.flavor = flavor;
            this.action = action;
            this.effects = effects;
            this.notes = notes;
            this.count = count;
        }
    }
}
 