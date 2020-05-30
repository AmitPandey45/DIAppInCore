namespace locDemo.Repository.Designation
{
    public class DesignationEntity
    {
        public string Designation { get; set; }
        public bool IsConsulted { get; set; }
        public bool IsReferencedInRegulation { get; set; }
        public bool IsNormativeReference { get; set; }
        public bool IsUsedAsBasisForNationalStandard { get; set; }
        public bool IsAdoption { get; set; }
        public int QuantitySold { get; set; }
    }
}
