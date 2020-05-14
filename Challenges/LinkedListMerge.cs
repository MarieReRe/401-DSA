using static DataStructures.LinkedList;
using DataStructures;

namespace Challenges
{
    public class LLMerge
    {
        public static LinkedList Merge(LinkedList firstList, LinkedList secondList)
        {
            //if one head is null return the opposite list
           if(firstList.Head == null)
            {
                return secondList;
            }
           if(secondList.Head == null)
            {
                return firstList;
            }

           //if both lists are null return null
           if(firstList == null && secondList == null)
            {
                return null;
            }
            //set up our currents to be the Head
            Node CurrentFirstList = firstList.Head;
            Node CurrentSecondList = secondList.Head;

            //merge one node after the other
            while(CurrentFirstList != null && CurrentSecondList != null)
            {
                secondList.Head = CurrentSecondList;
                CurrentSecondList.Next = CurrentFirstList.Next;
                CurrentFirstList = CurrentFirstList.Next;
                CurrentSecondList = secondList.Head;
            }


            //check if the second list current isnt null
            if(CurrentSecondList != null)
            {
                CurrentFirstList.Next = CurrentSecondList;
            }

            return firstList;
        }
    }
}
