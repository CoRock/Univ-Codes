# Operating System



### 커널

OS의 핵심적인 부분으로 주로 자원을 관리한다.



### 문맥교환

실행 중인 프로세스를 다른 프로세스로 교체하기 위해 문맥을 각각 save하고 restore하는 일



### 다중프로그래밍(multiprogramming)

여러 개의 프로세스들을 동시에 운영하는 기법



### 시분할 시스템

CPU time을 조금씩 분할해서 각 사용자에게 나눠 주는 interactive system


### 쓰레드?

CPU 수행과 관련된 정보(PC, Register, stack)만 별도로 가지는 경량 프로세스



### 임계구역

공유 데이터 등 atomic하게 실행되어야 하는 프로그램 세그먼트


### 프로세스 상태

- `running` : CPU를 잡고 instruction이 수행중인 상태
- `blocked` : CPU를 줘도 당장 instruction을 수행을 못하는 상태
(자신이 요청한 event가 즉시 만족되지 않아 기다리는 상태)
- `ready` : 메모리 등 다른 조건을 모두 만족한 채로 CPU를 기다리는 상태
- `suspended` 구역 : 메모리가 부족한 상태
