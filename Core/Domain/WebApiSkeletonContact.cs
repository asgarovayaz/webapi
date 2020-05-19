namespace WebApiSkeleton.Core.Domain
{
    public class WebApiSkeletonContact
    {
        public long Id { get; set; }
        public long? WebApiSkeletonsId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual WebApiSkeletons  WebApiSkeletons { get; set; }
    }
}
