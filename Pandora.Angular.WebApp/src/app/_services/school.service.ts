import { Grade, Class, Student, Subject } from "@/_models";
import { HttpClient } from '@angular/common/http';
import { Injectable } from "@angular/core";
import { Observable } from 'rxjs';
import { BaseService } from './base.service';

@Injectable()
export class SchoolService extends BaseService {

    constructor(http: HttpClient) {
        super(http);
    }

    public getGrades(): Observable<Grade[]> {
        this.path = "grades";
        return this.get<Grade>();
    }

    public getClassesByGradeId(gradeId: number): Observable<Class[]> {
        this.path = "classes/GetByGrade";
        return this.getById<Class[]>(gradeId);
    }

    public getSubjectsByTeacherId(teacherId: number): Observable<Subject[]> {
        this.path = "subjects/GetByTeacher";
        return this.getById<Subject[]>(teacherId);
    }
    
    public getStudentsByClassId(classId: number): Observable<Student[]> {
        this.path = "students/GetByClass";
        return this.getById<Student[]>(classId);
    }

}