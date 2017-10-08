using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSProject2
{
    public class ResultsList
    {
        private List<Results> ListOfResults;

        public ResultsList()
        {
            ListOfResults = new List<Results>();
        }

        public void AddResult(Results newResult)
        {
            ListOfResults.Add(newResult);
        }

        public void ComputeBestResult()
        {
            int bestResultIndex = 0, secondIndex = -1, thirdIndex = -1, fourthIndex = -1;

            double bestTT = ListOfResults[0].TT;
            bool multiple = false;

            // find Result with lowest TT 
            for (int i = 0; i < ListOfResults.Count; i++)
            {
                if (ListOfResults[i].TT < bestTT)
                {
                    bestResultIndex = i;
                    bestTT = ListOfResults[i].TT;
                    multiple = false;
                    secondIndex = -1;
                    thirdIndex = -1;
                    fourthIndex = -1;
                }
                if(ListOfResults[i].TT == bestTT && ListOfResults[i].Name != ListOfResults[bestResultIndex].Name)
                {
                    multiple = true;
                    if(secondIndex == -1)
                    {
                        secondIndex = i;
                    }
                    else if(thirdIndex == -1)
                    {
                        thirdIndex = i;
                    }
                    else if(fourthIndex == -1)
                    {
                        fourthIndex = i;
                    }
                }
            }

            if (!multiple)
            {
                // print result name and tt 
                System.Console.WriteLine("Best policy is " + ListOfResults[bestResultIndex].Name
                    + " with an Average Turnaround Time of " + ListOfResults[bestResultIndex].TT + "\n\n\n");
            }
            else
            {
                StringBuilder finalResult = new StringBuilder();
                finalResult.Append("Best policies include: " + ListOfResults[bestResultIndex].Name);

                if(secondIndex != -1)
                {
                    finalResult.Append(", " + ListOfResults[secondIndex].Name);

                    if(thirdIndex != -1)
                    {
                        finalResult.Append(", " + ListOfResults[thirdIndex].Name);

                        if(fourthIndex != -1)
                        {
                            finalResult.Append(", " + ListOfResults[fourthIndex].Name);
                        }
                    }
                }
                
                finalResult.Append(" each with an Average Turnaround Time of " + ListOfResults[bestResultIndex].TT + "\n\n\n");

                System.Console.WriteLine(finalResult.ToString());
            }  
        }
    }
}
