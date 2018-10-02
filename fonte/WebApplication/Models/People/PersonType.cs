namespace WebApplication.model.People
{
    public class PersonType
    {
        public enum Gender
        {
            female = 0,
            male = 1
        }

        public enum Type
        {
            physical = 0,
            juridical = 1
        }

        public string GetLabel(string define, int id)
        {
            string pross = null;

            if ((!string.IsNullOrEmpty(define) && define != "") &&(id>0))
            {
                if (define == "Type")
                {
                    if (id == 0)
                    {
                        pross = "F";
                    }
                    else if (id == 1)
                    {
                        pross = "J";
                    }
                    else
                    {
                        pross = null;
                    }
                }
                else if (define == "Gender")
                {
                    if (id == 0)
                    {
                        pross = "F";
                    }
                    else if (id == 1)
                    {
                        pross = "M";
                    }
                    else
                    {
                        pross = null;
                    }
                }

                return pross;
            }
            else
            {
                return null;
            }
        }

    }
}