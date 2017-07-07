using Atata;

namespace $rootnamespace$
{
    public class $safeitemrootname$ : TriggerAttribute
    {
        public $safeitemrootname$(TriggerEvents on, TriggerPriority priority = TriggerPriority.Medium)
            : base(on, priority)
        {
        }

        protected override void Execute<TOwner>(TriggerContext<TOwner> context)
        {
        }
    }
}
