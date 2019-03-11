using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterBuilder
{
    public class Character
    {
        private string _CharacterName;
        private string _Class;
        private string _Background;
        private Dictionary<string, int> _Stats;
        private Dictionary<string, string> _ClassFeatures;
        private Dictionary<string, string> _BackgroundFeatures;
        private string _Biography;
        private int _HitPoitns;
        private Dictionary<string, string> _Feats;
        private System.Collections.Generic.Dictionary<string, string> _Spells;

        //public string Background
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        //public Dictionary<string, string> BackgroundFeatures
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        //public string Class
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        //public Dictionary<string, string> ClassFeatures
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        ///// <summary>
        ///// Dictionary of the characters statistics
        ///// </summary>
        //public Dictionary<int, string> Stats
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        ///// <summary>
        ///// Characters Name
        ///// </summary>
        //public String Name
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        //public string Description
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        //public string Biography
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        ///// <summary>
        ///// Characters Hit Points
        ///// </summary>
        //public int HitPoints
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        ///// <summary>
        ///// Dictionary of the characters Feats
        ///// </summary>
        //public Dictionary<string, string> Feats
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}

        ///// <summary>
        ///// Dictionary of the characters spells
        ///// </summary>
        //public Dictionary<string, string> Spells
        //{
        //    get => default(int);
        //    set
        //    {
        //    }
        //}
    }
}