todo :
Input
Addressable
UniTask, R3

CustomCor
Tween

-Unity Project
내부 최상위 폴더명은 prefix "_" 로 시작한다.
폴더정렬에 포함하지 않을 폴더는 prefix "__"로 시작한다.

-Unity C#
되도록 유니티의 기본 코루틴은 사용하지 않는다
-Custom Coroutine 을 사용한다.

Coroutine			에 사용하는 IEnumerator 를 반환하는 함수는 prefix "C_" 	로 시작한다.
Custom Coroutine 	에 사용하는 IEnumerator 를 반환하는 함수는 prefix "CC_"	로 시작한다.

-C#
var 키워드는 되도록 쓰지 않는다.

const 		변수는 		모두 대문자로 쓴다.
static		변수는 		prefix "s_" 	로 시작한다.
local		변수/함수는	prefix "l_		로 시작한다.

property 	변수는 prefix "Get" 			로 시작한다.

public field는 사용하지 않는다
-public property로 대체한다.

재귀 함수는 이름 뒤에 Recursive를 붙인다.

Nullable은 되도록 쓰지 않으며 sentinal value 를 사용한다.


-빌드
Debug 클래스를 지운다
