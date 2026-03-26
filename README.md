# (C# 코딩) 에코 메신저

## 개요
- C# 프로그래밍 학습
- 1줄 소개 : 사용자의 버튼 사용을 바탕으로 계산기 구동을 하게하는 프로그램
- 사용한 플랫폼 : C#, NET windows Forms, Visual Studio, Github
- 핵심기능 : 계산기 작동
- 화면구성 : button, label, textbox

## 실행 화면

- 1단계 코드의 실행 스크린샷
<img width="625" height="531" alt="image" src="https://github.com/user-attachments/assets/1f7f4946-649e-4da3-bf08-078f15c4fc9a" />


이 프로그램은 사용자가 숫자를 입력하고, 즉시 결과를 확인할 수 있는 입력 시스템이다,
UI는 Label, TextBox, Button, ListBox로 구성되어 있습니다.

-Label: 사용자가 현재 입력 중인 숫자를 실시간으로 보여줍니다.

-TextBox: 숫자를 입력하는 공간으로, 키보드 입력과 프로그램 내 숫자 버튼 클릭 모두 지원됩니다.

-Button(전송): 클릭하면 TextBox의 값을 확인(IsNullOrEmpty 사용)하고, 값이 있으면 ListBox에 바로 출력합니다.

-ListBox: 입력된 숫자를 기록하며, 결과를 확인할 수 있는 창입니다.



- 2단계 코드의 실행 스크린샷
<img width="620" height="524" alt="image" src="https://github.com/user-attachments/assets/4d400481-9a21-4eb4-9c69-488c9072080c" />


이 프로그램은 기존의 숫자 입력 기능에 사칙연산 기능을 확장한 구조입니다. 기존 UI에 더해 빼기, 곱하기, 나누기 버튼을 추가했습니다.

곱셈과 나눗셈의 경우, 사용자가 이해하기 쉽게 표시되는 X와 ÷를 내부 연산에서는 *와 /로 변환하여 처리합니다. 

이렇게 하면 동일한 계산 로직을 재사용하면서도 사용자에게 직관적인 기호를 보여줄 수 있습니다.


- 3단계 코드의 실행 스크린샷
![20260326-0307-04 7725697](https://github.com/user-attachments/assets/b36952f1-756c-4e48-9ac6-9f56bb395ae3)


프로그램에 CE, Del, C 버튼을 추가하여 입력 편의성을 강화했습니다. 각 버튼의 기능은 다음과 같습니다.

C (Clear): 현재 입력과 연산, 결과 등 모든 내용을 초기화합니다.

Del (Delete): TextBox에서 마지막 입력 글자를 삭제합니다.

CE (Clear Entry): 마지막 입력한 피연산자만 삭제합니다.


- 4단계 코드의 실행 스크린샷
<img width="612" height="632" alt="image" src="https://github.com/user-attachments/assets/ce65c504-3efd-4123-8b90-9bebacb39639" />

<img width="610" height="627" alt="image" src="https://github.com/user-attachments/assets/70a76336-a6b4-4963-9a4e-9622c8d82ce8" />


프로그램에 제곱근 버튼과 괄호 기능을 추가하여 연산 활용도를 확장했습니다.

제곱근 버튼: 사용자가 제곱하려는 수를 입력한 후 버튼을 클릭하면, 기존 결과값을 기준으로 새로운 제곱 수로 계산되어 바로 출력됩니다. 이를 통해 연속적인 제곱 연산이 가능합니다.

괄호 기능: 연산에서 곱하기(*)를 생략하고 입력 순서대로 계산하도록 활용할 수 있습니다. 

곱셈 기호를 생략해도 내부적으로 자동으로 곱셈 연산이 적용되어 계산됩니다.

# 느낀점
- 이번 프로젝트를 진행하면서, 입력과 연산이 실시간으로 반영되도록 동기화하는 것이 중요하다는 것을 느꼈습니다.

- Del, CE, C, 제곱근, 괄호 기능을 구현하며, 사용자가 편리하게 입력하고 즉시 결과를 확인할 수 있는 구조를 설계하는 경험이 유익했습니다.
 
