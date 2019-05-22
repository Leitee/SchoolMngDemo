//     This code was generated by a Reinforced.Typings tool. 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.

declare enum AttendanceEnum { 
	ATTEND = 1, 
	MISS = 2, 
	REASON = 3
}
declare enum ExamTypeEnum { 
	FIRST = 1, 
	SECOND = 2, 
	THIRD = 3, 
	RETRY = 4, 
	FINAL = 5
}
declare enum RolesEnum { 
	ADMINISTRADOR = 1, 
	SUPERVISOR = 2, 
	TEACHER = 3, 
	STUDENT = 4, 
	DEBUG = -1
}
declare enum ShiftTimeEnum { 
	TOMORROW = 1, 
	AFTERNOON = 2, 
	NIGHT = 3
}
declare enum StudentStateEnum { 
	ENROLLED = 1, 
	ACTIVE = 2, 
	INACTIVE = 3, 
	ACHIEVED = 4
}
export interface Attend
{
	id: number;
	attendance: AttendanceEnum;
	date: any;
	obs: string;
	student: Student;
	subject: Subject;
}
export interface Class
{
	id: number;
	name: string;
	shift: ShiftTimeEnum;
	grade: Grade;
}
export interface Exam
{
	id: number;
	examType: ExamTypeEnum;
	score: number;
	date?: any;
	obs: string;
	studentId: number;
	subjectId: number;
	student: Student;
	subject: Subject;
}
export interface Grade
{
	id: number;
	name: string;
}
export interface Login
{
	username: string;
	password: string;
	rememberMe: boolean;
}
export interface Register extends Login
{
	email: string;
	firstName: string;
	lastName: string;
	confirm: string;
}
export interface Role
{
	id: number;
	name: string;
	description: string;
}
export interface Student
{
	id: number;
	firstName: string;
	lastName: string;
	email: string;
	phoneNumber: string;
	fullName: string;
	address: string;
	subjectStates: StudentState[];
	studentState: StudentState;
}
export interface StudentState
{
	id: number;
	academicState: StudentStateEnum;
	dateFrom: any;
	dateTo?: any;
	student: Student;
	subject: Subject;
	obs: string;
}
export interface SubjectAssingment
{
	id: number;
	date: any;
	disable: boolean;
	subjectId: number;
	subject: Subject;
	classId: number;
	class: any;
	classRoomId?: number;
	classRoom: any;
	teacherId?: number;
	teacher: any;
}
export interface Subject
{
	id: number;
	name: string;
	preReqSubjects: Subject[];
	attends: Attend[];
	exams: Exam[];
}
export interface Teacher
{
	id: number;
	subjectAssingments: any[];
}
export interface LoginResp
{
	token: string;
	expirationDate: number;
	hasToken: boolean;
	messageResponse: string;
}
export interface User
{
	id: number;
	userName: string;
	email: string;
	phoneNumber: string;
	firstName: string;
	lastName: string;
	fullName: string;
	joinDate: any;
	role: Role;
}
