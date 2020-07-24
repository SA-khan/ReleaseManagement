public class ENVIRONMENT_TYPE
{
    public virtual int ENV_TYPE_ID { get; set; }
    public virtual string ENV_TYPE_TITLE { get; set; }
    public virtual string ENV_TYPE_DESC { get; set; }

    public ENVIRONMENT_TYPE(int ENV_TYPE_ID)
    {
        this.ENV_TYPE_ID = ENV_TYPE_ID;
    }

}