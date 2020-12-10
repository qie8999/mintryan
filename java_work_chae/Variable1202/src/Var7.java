
public class Var7 {

	public static void main(String[] args) {
		//0은 숫자 o는 영문
		byte num = 'A'; //A는 아스키코드
		System.out.println(num);
		
		short char1 = 'B'; //short는 int의 반
		char char2 =66;
		long num2 = 9876543210L;//L은 long형 이라는 뜻
	

		System.out.println("num : " + num);
		System.out.println("char1 : " + char1);
		System.out.println("char2 : " + char2);
		System.out.println("num2 : " + num2);
	
		int result = num + 32;
		System.out.printf("num + 3 = %d\n", result); 
		//printf 는 복잡한 내용 쓸때 print 보다 편하게 쓸 수 있다
		//d 는 10진수
		
		System.out.printf("result : %c\n",result);
		//c 는 캐릭터
		
	}

}
