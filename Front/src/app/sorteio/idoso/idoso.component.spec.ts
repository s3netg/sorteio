/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { IdosoComponent } from './idoso.component';

describe('IdosoComponent', () => {
  let component: IdosoComponent;
  let fixture: ComponentFixture<IdosoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ IdosoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(IdosoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
