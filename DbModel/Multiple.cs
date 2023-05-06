public class Multiple{
  public int Id { get; set; }
  public int emp_id { get; set; }
  public string company_name { get; set; }
  protected string emp_name { get; set; }

  public string vendor_name { get; set; }
  public DateTime? inv_rec_date { get; set; }
    public string statement { get; set; }
  public string invoice_number { get; set; }
    public int amount { get; set; }
    public string authorized_by { get; set; }=null;
    public string? debited_to { get; set; }
    public string? remark { get; set; } =null;
    public string invoice { get; set; }=null;
    public string file_name { get; set; } =null;
    public string file_size { get; set; } =null;
    public string created_by{get; set; }
    public string invoiceType{get; set;}
    protected int bookingId { get; set; }


}