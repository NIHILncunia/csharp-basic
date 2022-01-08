namespace csharpBasic.Training; 

public class Tr011NestedClass {
  private string _name = "NIHILncunia";
  // 프라이빗의 경우 다른 클래스에서는 접근이 안된다.

  private class InsideClass {
    public void insideMethod() {
      Tr011NestedClass tr11 = new Tr011NestedClass();
      tr11._name = "니힐 NIHIL";
      // 중첩 클래스에서는 프라이빗 멤버에도 접근이 가능하다. 다른 클래스지만 내부의 클래스이기 때문이다.
      
      Console.WriteLine(tr11._name);
      Console.WriteLine();
    }
  }
  // 이 중첩 클래스는 프라이빗으로 제한했기 때문에 다른 클래스에서는 보이지 않는다.
  // 중첩 클래스를 사용하는 이유는 다른 곳에서 보이지 않는 프로세스를 작업하고 싶을 때에 주로 만든다.

  public void n1_NestedClass() {
    InsideClass ic = new InsideClass();
    ic.insideMethod();
    // 중첩 클래스에 접근하는 방법도 똑같다.
  }
}