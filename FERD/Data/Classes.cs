using FERD.Helpers;
using FERD.Models;

namespace FERD.Data
{
    public static class Classes
    {
        // Classes CSV Header Index
        public static class CCHI
        {
            public static readonly int CLASS = 0;
            public static readonly int TIER = 1;
            public static readonly int HP = 2;
            public static readonly int SM = 3;
            public static readonly int SKL = 4;
            public static readonly int SPD = 5;
            public static readonly int DEF = 6;
            public static readonly int RES = 7;
            public static readonly int TOTAL = 8;
            public static readonly int MOVE = 9;
            public static readonly int WEAPONS = 10;
            public static readonly int FEATURES = 11;
            public static readonly int PROMOTIONS = 12;
            public static readonly int DESC = 13;
        }

        private static Dictionary<String, ClassType> _classMap = new Dictionary<string, ClassType>();

        public static Dictionary<String, ClassType> ClassMap
        {
            get
            {
                if (_classMap.Count() == 0)
                {
                    string csvContent = ResourceHelper.GetCsvContent("classes");

                    using (StringReader reader = new StringReader(csvContent))
                    {
                        string? row = reader.ReadLine(); // Pop the first row (the header row) here so it gets skipped
                        string[] rowSplit;
                        while ((row = reader.ReadLine()) != null)
                        {
                            rowSplit = row.Split(',');
                            ClassType obj = new ClassType()
                            {
                                Name = rowSplit[CCHI.CLASS],
                                Tier = int.Parse(rowSplit[CCHI.TIER]),
                                GrowthRates = new Stats()
                                {
                                    HP = int.Parse(rowSplit[CCHI.HP]),
                                    SM = int.Parse(rowSplit[CCHI.SM]),
                                    SKL = int.Parse(rowSplit[CCHI.SKL]),
                                    SPD = int.Parse(rowSplit[CCHI.SPD]),
                                    DEF = int.Parse(rowSplit[CCHI.DEF]),
                                    RES = int.Parse(rowSplit[CCHI.RES])
                                },
                                Move = int.Parse(rowSplit[CCHI.MOVE]),
                                Subclasses = rowSplit[CCHI.PROMOTIONS].Replace(" ", "").Split('|'),
                                Weapons = rowSplit[CCHI.WEAPONS].Replace(" ", "").Split('|'),
                                Features = rowSplit[CCHI.FEATURES].Replace(" ", "").Split('|'),
                                Description = rowSplit[CCHI.DESC]
                            };

                            _classMap.Add(obj.Name, obj);
                        }
                    }
                }

                return _classMap;
            }
        }

        public static List<ClassType> None => new List<ClassType> { Null };
        public static List<ClassType> Tier1 => ClassMap.Values.Where(c => c.Tier == 1).ToList();
        public static List<ClassType> Tier2 => ClassMap.Values.Where(c => c.Tier == 2).ToList();
        public static List<ClassType> Tier3 => ClassMap.Values.Where(c => c.Tier == 3).ToList();


        public static ClassType Null => new ClassType()
        {
            Name = " - ",
            Tier = 0,
            GrowthRates = new Stats()
            {
                HP = 0,
                SM = 0,
                SKL = 0,
                SPD = 0,
                DEF = 0,
                RES = 0
            },
            Subclasses = new string[] {},
            Weapons = new string[] { },
            Features = new string[] { },
            Description = " - "
        };
    }
}
