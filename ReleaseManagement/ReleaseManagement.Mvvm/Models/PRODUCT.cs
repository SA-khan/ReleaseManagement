public class PRODUCT
{
    public virtual int PROD_ID { get; set; }
    public virtual string PROD_NAME { get; set; }
    public virtual string PROD_TAGLINE { get; set; }
    public virtual string PROD_IMAGE_SRC { get; set; }
    public virtual string PROD_DESC { get; set; }
    public virtual string PROD_VERSION { get; set; }
    public virtual string PROD_TYPE { get; set; }
    public virtual string PROD_CATEGORY { get; set; }
    public virtual string PROD_RATING { get; set; }
    public virtual string PROD_DEMO_USER_ID { get; set; }
    public virtual string PROD_DEMO_PASSWORD { get; set; }
    public virtual string PROD_POC_NAME { get; set; }
    public virtual string PROD_SUPPORT_EMAIL { get; set; }
    public virtual string PROD_COMMENTS { get; set; }

    public PRODUCT(int PROD_ID)
    {
        this.PROD_ID = PROD_ID;
    }

}