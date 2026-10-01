# C# Week 2 — Text RPG

## 구현한 기능

- Player / Enemy 클래스 구현
- Player와 Enemy 간 전투 시스템 구현
- HP 및 공격력 시스템 구현
- 공격 시 상대 HP 감소
- HP가 0 이하가 되면 전투 종료
- 잘못된 메뉴 예외 처리
- `List<Enemy>`를 이용한 Enemy Collection 구현
- `Random`을 이용해 여러 Enemy 중 하나를 랜덤 선택
- 상태 확인 메서드 구현

## 클래스 구조

### Player

플레이어의 이름, HP, 공격력을 저장

- `name` : 플레이어 이름
- `hp` : 플레이어 체력
- `attackPower` : 플레이어 공격력
- `Attack(Enemy enemy)` : Enemy 객체를 공격하고 HP를 감소시킴

### Enemy

적의 이름, HP, 공격력을 저장

- `name` : Enemy 이름
- `hp` : Enemy 체력
- `attackPower` : Enemy 공격력
- `Attack(Player player)` : Player 객체를 공격하고 HP를 감소시킴

### Game

게임 전체 진행을 담당합니다.

- Player 및 Enemy 객체 생성
- `List<Enemy>`를 이용한 Enemy 관리
- 랜덤 Enemy 선택
- 메뉴 및 전투 반복 처리
- `ShowStatus()`를 이용한 현재 HP 출력
- 승리 / 패배 / 게임 종료 처리

## 배운 점 / 막힌 점

C#에 벡터가 없었어... 뭐가 그리워짐 벡터가
일단 메소드 뽑아내는 연습을 많이 할 수 있었고 C++때도 잘 못했던 클래스를 연습을 많이 할 수 있어서 좋았음
아직 스스로 짜내는 힘은 부족한 것 같아서 문법 연습이랑 이런저런 예제를 더 풀어보는게 좋을 것 같다고 생각했습니다.
중간 끝나고 놀지 않고 열심히 하겠어요 ..
