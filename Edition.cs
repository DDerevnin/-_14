using System;

namespace Homework12
{
    public abstract class Edition : IComparable<Edition>
    {
        public string Name { get; set; }
        public int Year { get; set; }
        public EditionType Type { get; set; }
        public abstract string GetInfo();
        public string GetEditionTypeName()
        {
            switch (Type)
            {
                case EditionType.Almanac:
                    return "Альманах";
                case EditionType.Catalogue:
                    return "Каталог";
                case EditionType.Magazine:
                    return "Журнал";
                case EditionType.Newspaper:
                    return "Газета";
                    
            }
            return "Другое";
        }

        public int CompareTo(Edition other)
        {
            if (Name != other.Name)
                return Name.CompareTo(other.Name);
            return -Year.CompareTo(other.Year);
        }
    }
}