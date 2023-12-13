using System.ComponentModel.DataAnnotations;

namespace ereditarycode.console
{
    public class SupremeEntities
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get; set; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }
    }

    public class OriginallyRelashionship
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }
    }

    public class FaterAndMotherOriginally
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string FatherCompleteName { get; set; }
        public string MotherCompleteName { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }

    }

    public class FaterAndMotherActual
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string FatherCompleteName { get; set; }
        public string MotherCompleteName { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public Children? Children { get; set; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public Relashionship Relashionship { get; set; }
        public FaterAndMotherActual? Parents { get; set; }
        public FaterAndMotherOriginally? ParentsOriginal { get; set; }
        public OriginallyRelashionship OriginallyRelashionship { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }

    }

    public class HousbandAndWifeOfFamily
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }
    }
    public class FamilyMember
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }
    }
    public class FamilyMembers
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }

    }

    public class Wifes
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }
    }

    public class Children
    {
        private string? parentalBond;
        private int parentalCode;
        private int individualCode;
        private int? parentalConnectionCode;
        private DateTime creationDate;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string? Nickname { get; set; }
        public int Age { get; set; }
        public int IndividualCode { get => individualCode; set => individualCode = IncrementalAndCheckFamilyMembers.CheckIndividualCode(individualCode) ? IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(individualCode) : individualCode; }
        public int ParentalCode { get => parentalCode; set => parentalCode = IncrementalAndCheckFamilyMembers.CheckParentalCode(parentalCode) ? parentalCode : IncrementalAndCheckFamilyMembers.AutoIncrementalGuild(parentalCode); }
        public string? ParentalBond { get => parentalBond; set => parentalBond = ParentalCode.ToString(); }
        public int? ParentalCodeFamily { get => parentalConnectionCode; protected set => parentalConnectionCode = ParentalBond != null ? ParentalCode : null; }
        public DateTime? CreationDate { get => creationDate; set => creationDate = ParentalCode != 0 || ParentalBond != string.Empty ? DateTime.UtcNow : DateTime.MinValue; }
        public ActualGender ActualGender { get; set; }
        public OriginalGender OriginalGender { get; set; }
        public int? OriginallyRelashionshipID { get; set; }
        public Status Status { get; set; }
        public StatusInLife StatusInLife { get; set; }
        public int? ChildrenID { get; set; }
        public int? FatherAndMotherActualID { get; set; }
        public int? FatherAndMotherOriginallyID { get; set; }
        public int? HousbandANdWifeOfFamilyID { get; set; }
        public int? WifesID { get; set; }

    }

    public enum Area
    {
        Space,
        Surface,
        Sky
    }

    public enum StatusInLife
    {
        Freedom,
        UnderCaptured,
        InDanger,
        Killed
    }

    public enum Status
    {

        alive,
        death,
        inAcoma,
        impaired,
        withOnlyHead,
        withOnlyBody,
        withOnlyBrain,
        withOnlyArmLeft,
        withOnlyArmRight,
        withOnlyLegLeft,
        withOnlyLegRight,
        withOnlyFootLeft,
        withOnlyFootRight,
        resurrected
    }

    public enum OriginalGender
    {
        male,
        female
    }
    public enum ActualGender
    {
        male,
        female,
        transgender
    }
    public enum Relashionship
    {
        Single,
        Fiancé,
        Married,
        Widower
    }

}