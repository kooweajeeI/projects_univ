스마트팜) POWER ON, 제어보드 + PC 연결

PC)
1. 아두이노 개발통합환경(Arduino IDE) 설치 및 실행
2. 펌웨어 코드 업로드
3. nodejs설치  ver.) 12.18.2-x64.msi(64bit)
          (https://nodejs.org/ko/download/releases/)  
4. node-red 
	1) 명령 프롬프트에서 마우스 우측 클릭
	2) 자세히 => 관리자 권한으로 실행
	3) 해당 프로그램 폴더로 변경 
		=> cd C:\Program Files\nodejs
	[1] 설치
	1) 버전 확인 => node --version && npm --version
	2) node red 설치 => npm install -g —unsafe-perm node-red
	[2] 실행
	 설치된 node red 실행 => node-red
5. 웹에서 node-red 열람 (웹에서 정상동작 확인)
	-> localhost:1880 
6. dashboard에서 엑추에이터 제어
	1) [메뉴]-[팔렛트 관리] 선택
	2) [node-red-dashboard],[String], [node-red-contrib-string] 설치
7. node-red ip주소 / 배포
	스마트팜 LCD에 출력된 Wi-Fi ip주소로 변경 후, 배포하기

8. nginx
	1) 설치파일 다운로드 = > http://nginx.org/en/download.html
	2) 압축 해제 후 node-red 연동을 위해 동일한 폴더에 위치하게 함
	3) NGINX 실행 (nginx.exe)
		=> cd c:\
		=> unzip nginx-1.19.1.zip
		=> cd nginx-1.19.1
		=> start nginx
   	6) 방화벽 해제[액세스 허용]
	7) 웹에서 정상동작 확인(http://127.0.0.1:1990/)

9. FileZilla 서버용 프로그램 설치
	1) FileZilla 사용법- 계정만들기
	•  Filezilla interface 실행
	•  개인 설정 => General => 계정 / 비번 설정 : admin(admin)

	2) 공유 폴더 위치 설정하기
	•  Share folders => 공유할 폴더 위치 설정
	(C:\Program Files\nodejs\nginx-1.18.0\html\SMARTFARM_IMAGES)

	3) FileZilla 실행
	•  [ FileZilla Server Interface ] 실행
	•  실행된 화면에서 File/Connect to server를 실행
	•  FTP 로그인을 위한 정보를 입력 
		=> Host : 127.0.0.1 (고정 ip; 변경할 필요 없음)
		=> Port : 14147 (default)

App)
1. 앱 설치(apk파일)
2. 블루투스 기기 등록(안드로이드 기기에서 설정)
3. 앱 실행 - 블루투스 연결
4. 엑추에이터 제어기능 
5. 사진촬영
  => 카메라 버튼 눌러 촬영 후, 업로드 버튼 누르기 (방화벽 확인)