namespace SitecoreJobViewer.Models
{
    public class JobNameHandle
    {
        public JobNameHandle(string name, string handle) 
        { 
            this.Name = name;
            this.Handle = handle; 
        }

        public string Name { get; set; }

        public string Handle { get; set; }

        public override bool Equals(object obj)
        {
            var jobHandle = obj as JobNameHandle;

            if (jobHandle == null)
                return false;

            return jobHandle.Handle.Equals(Handle);
        }

        public override int GetHashCode()
        {
            return Handle.GetHashCode();
        }
    }
}
