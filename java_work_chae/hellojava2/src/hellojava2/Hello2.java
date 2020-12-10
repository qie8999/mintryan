package hellojava2;

public class Hello2 {

	public static void main(String[] args) {
		// 문자열/ 문자/ 숫자를 알아보자
		// "  "안에 있는 정보 "홍길동" = 문자열(텍스트)
		System.out.println("이름:"+"홍길동");
		//문자열은 꼭 ""가 있어야 한다 ""안에 있는 모든 것은 문자열, 없으면 정수
		//100 = 정수
		System.out.println("나이:"+100);
		//중간에 +를 넣어주지 않으면 에러가 남  숫자+문자의 적용= 숫자가 문자로 바뀐다
		System.out.println("100+200="+(100+200));//산술연산이 된다
		
		//10.5 =실수        몸무게66.5kg 문자로 바뀐다
		System.out.println("몸무게"+66.5+"kg");
		//'a' '흥' ''은 외자에 쓴다 문자를 나타낸다
		//'흥'문자    "흥"문자열을 나타낸다 (한글자에도 ""를 쓸 수 있다) 
		System.out.println('흥'+'흥');
	

	}

}
