
public class Var1 {//첫글자가 대문자이면 class라고 생각하면 된다

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		String str = "홍길동"; //문자열 입력(숫자 사용 불가), str은 변수 
		//문자열을 str에 저장한다는 뜻 (오른쪽에서 왼쪽으로 해석)
		//String는 문자열 입력할 때 사용 첫자는 대문자로(타입이라고 함)
		//변수 이름은 내가 마음대로 지을 수가 있다 (앞에 숫자가 올 수 없다) 
		//글자 밑에 노란색 줄은 철자검사. 신경쓰지 않아도 된다
		
	
		System.out.println("str : " + str); //str 앞에 ""로 보기 편하게 적어준다
		String STR = "홍길동";
		System.out.println("STR : " + STR);
		//변수 이름을 직관적으로 표현하는게 좋다(기본)
		//또는 지어놓고 옆에 주석을 달아주면 좋다
		
		String name1;//문자열(string) 타입 변수 선언(이 변수 쓰겠다)
		name1 = "김길동";  //String name = "김길동";과 같은 용법인데 두줄이고 한줄 차이임
		System.out.println("name1 : " + name1);
		
		
		name1 = "박길동";  //두번째 선언하면 김길동 ->박길동으로 바뀐다는 뜻 (변수 재사용 가능. 횟수 무제한)
		System.out.println("name1 : " + name1); //name1을 출력해준다
		
		
		
		
		
		
		
		
		

	}

}
