public abstract class Lead : EntityBase
{
    public string Source {get; set;}
    public string LaedStatus{get; set;}

    public Lead(){}

    public Lead(string S)
    {
        Source = S;
    }
    public virtual string AssignOwner(string managerName)
    {
        
    }
    public virtual void MoveNextStatus()
    {
        
    }
    public override void Validate()
    {
        
    }
   

} 