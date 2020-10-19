using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models {
public class Child : Person {
    
    public List<ChildInterest> ChildInterests { get; set; }
    [ValidateComplexType] public List<Pet> Pets { get; set; }

    public void Update(Child toUpdate) {
        base.Update(toUpdate);
        ChildInterests = toUpdate.ChildInterests;
        Pets = toUpdate.Pets;
    }

}
}