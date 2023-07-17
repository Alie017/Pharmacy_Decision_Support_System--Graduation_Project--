import { PatientSignup, PatientSignin, PharmacistSignup, PharmacistSignin } from '../modules/auth'

export const authRoutes = [
  { path: '/signup/pharmacist', Element: PharmacistSignup },
  { path: '/signin/pharmacist', Element: PharmacistSignin },
  { path: '/signup/patient', Element: PatientSignup },
  { path: '/signin/patient', Element: PatientSignin },
]