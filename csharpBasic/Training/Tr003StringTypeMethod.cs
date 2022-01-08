namespace csharpBasic.Training; 

public class Tr003StringTypeMethod {
  public void n1_search() {
    string word = "바람을 세로질러 날아오르는 기분 so cool";
      
    Console.WriteLine(word);
    Console.WriteLine("");
      
    Console.WriteLine($"바람: {word.IndexOf("바람")}");
    Console.WriteLine($"세로: {word.IndexOf("세로")}");
    Console.WriteLine("");
    // 찾고자 하는 문자열의 시작 위치를 리턴한다.
      
    Console.WriteLine($"날아: {word.LastIndexOf("날아")}");
    Console.WriteLine($"기분: {word.LastIndexOf("기분")}");
    Console.WriteLine("");
    // 찾고자 하는 문자열을 뒤에서부터 찾고 시작 위치를 리턴한다.
      
    Console.WriteLine($"바람: {word.StartsWith("바람")}");
    Console.WriteLine($"cool: {word.StartsWith("cool")}");
    Console.WriteLine("");
    // 지정한 문자열로 시작하는지를 검사한다.
      
    Console.WriteLine($"바람: {word.EndsWith("바람")}");
    Console.WriteLine($"cool: {word.EndsWith("cool")}");
    Console.WriteLine("");
    // 지정하는 문자열로 끝나는지를 검사한다.
      
    Console.WriteLine($"바람: {word.Contains("바람")}");
    Console.WriteLine($"번개: {word.Contains("번개")}");
    Console.WriteLine("");
    // 지정한 문자열이 존재하는지를 검사한다.
      
    Console.WriteLine($"세로 => 가로: {word.Replace("세로", "가로")}");
    Console.WriteLine("");
    // 문자열의 특정 부분을 변경한다.
  }

  public void n2_modify() {
    Console.WriteLine($"ToLower: {"IU".ToLower()}");
    Console.WriteLine($"ToUpper: {"iu".ToUpper()}");
    Console.WriteLine();
    // 대문자와 소문자로 바꿀 수 있는 메소드
      
    Console.WriteLine($"Insert: {"IU".Insert(2, " Love.")}");
    Console.WriteLine($"Remove: {"I Don't Love IU".Remove(2, 6)}");
    Console.WriteLine();
    // 문자열의 특정 부분에 문자열을 추가하거나 지울 수 있는 메소드
      
    Console.WriteLine($"Trim: '{" IU ".Trim()}'");
    Console.WriteLine($"TrimStart: '{" IU ".TrimStart()}'");
    Console.WriteLine($"TrimEnd: '{" IU ".TrimEnd()}'");
    Console.WriteLine();
    // 문자열 앞뒤의 공백을 없앨 수 있는 메소드
      
  }

  public void n3_split() {
    const string word = "내 맘이 방심할 때마다 불쑥 나타난 뒤 헤엄치듯 멀어지는 너";

    int target = word.IndexOf("방심");
    Console.WriteLine($"SubString: {word.Substring(target, 5)}");
    // Substring 메소드는 원하는 구간을 잘라낼 수 있다.
    // IndexOf 메소드로 원하는 구간의 시작점을 찾는 게 보통인 듯하다.

    string[] splitString = {" "};
    // split 메소드의 구분자는 문자열 배열, 문자 배열, 문자로 지정할 수 있다.
    string[] arr = word.Split(splitString, StringSplitOptions.None);
    Console.WriteLine($"word count: {arr.Length}");
    Console.WriteLine();
    // 지정한 문자를 이용해 문자열을 문자 단위로 나눠 배열화시킨다.
    // StringSplitOptions.None의 경우 분리했을 때 비어있는 문자열도 남긴다는 의미다.
    // 두번째 인자에 숫자를 입력하면 그 숫자만큼만 나눠지게 된다. 갯수를 채운 뒤에는 나눠지지 않는다.
      
    foreach (string element in arr) {
      Console.WriteLine(element);        
    }
    Console.WriteLine();
    // 문자열이 나눠져서 만들어진 문자열 배열을 다시 반복문으로 돌려서 출력한다.
  }
}