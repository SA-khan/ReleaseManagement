public class CLIENT
{
    public virtual int CLI_ID { get; set; }
    public virtual string CLI_NAME { get; set; }
    public virtual string CLI_IMAGE_SRC { get; set; }
    public virtual string CLI_TYPE { get; set; }
    public virtual string CLI_DESC { get; set; }
    public virtual string CLI_POC_NAME { get; set; }
    public virtual string CLI_POC_EMAIL { get; set; }
    public virtual string CLI_POC_PHONE { get; set; }
    public virtual bool CLI_CURRENTLY_STATUS { get; set; }

    public CLIENT(int CLI_ID)
    {
        this.CLI_ID = CLI_ID;

    }

}