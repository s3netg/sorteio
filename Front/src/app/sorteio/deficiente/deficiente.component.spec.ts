/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { DeficienteComponent } from './deficiente.component';

describe('DeficienteComponent', () => {
  let component: DeficienteComponent;
  let fixture: ComponentFixture<DeficienteComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ DeficienteComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(DeficienteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
