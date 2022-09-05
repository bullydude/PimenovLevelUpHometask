namespace Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    internal class WarmupAttribute : Attribute
    {
        internal WarmupLevel Level { get; }
        
        public WarmupAttribute(WarmupLevel level = WarmupLevel.Init)
        {
            Level = level;
        }
    }

    internal enum WarmupLevel
    {
        Init = 0,
        Sync = 1,
        Ready = 2,
    }
}
