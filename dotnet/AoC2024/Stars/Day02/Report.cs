namespace Stars.Day02;

public class Report
{
    public List<int> Levels { get; set; }

    public List<int> Differences
    {
        get
        {
            var differences = new List<int>();

            int? previousLevel = null;
            foreach (var level in Levels)
            {
                if (previousLevel is not null)
                {
                    differences.Add(level - previousLevel.Value);
                }
            
                previousLevel = level;
            }

            return differences;
        }
    }

    public bool AreAllAscending
    {
        get
        {
            foreach (var difference in Differences)
            {
                if (difference <= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public bool AreAllDescending
    {
        get
        {
            foreach (var difference in Differences)
            {
                if (difference >= 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

    public bool IsSafe
    {
        get
        {
            // asc + desc = cannot (unsafe)
            // !asc + desc = true (maybe safe)
            // asc + !desc = true (maybe safe)
            // !asc + !desc = false (unsafe)
            if (AreAllAscending ==  AreAllDescending)
            {
                return false;
            }

            if (AreAllAscending)
            {
                foreach (var difference in Differences)
                {
                    if (difference < 1 || difference > 3)
                    {
                        return false;
                    }
                }
            }

            if (AreAllDescending)
            {
                foreach (var difference in Differences)
                {
                    if (difference > -1 || difference < -3)
                    {
                        return false;
                    }
                }
            }
        
            return true;
        }
    }
    
}