import React from 'react'
import { Routes, Route } from 'react-router-dom'

import Home from './components/Home/Home'
import { adminRoutes } from './routes/admin'
import { pharmacistRoutes } from './routes/pharmacist'
import { patientRoutes } from './routes/patient'
import { authRoutes } from './routes/auth'

import './style.css'
import 'react-toastify/dist/ReactToastify.css'
import { useSelector } from 'react-redux'

import Prescription from './medulla/pages/Prescription/Prescription'
import CreatePrescription from './medulla/pages/CreatePrescription/CreatePrescription'

export default function App() {
	const { theme } = useSelector(state => state.theme)

  return (
		<div className={`wrapper${theme === 'dark' ? ' dark' : ''}`}>
			<Routes>
				{/* Index Route */}
				<Route path='/' element={<Home />} />

				{/* Admin Routes */}
				{adminRoutes.map(({ path, Element }) => (
					<Route path={path} element={<Element />} key={path} />
				))}

				{/* Pharmacist Routes */}
				{pharmacistRoutes.map(({ path, Element }) => (
					<Route path={path} element={<Element />} key={path} />
				))}

				{/* Patient Routes */}
				{patientRoutes.map(({ path, Element }) => (
					<Route path={path} element={<Element />} key={path} />
				))}

				{/* Auth Routes */}
				{authRoutes.map(({ path, Element }) => (
					<Route path={path} element={<Element />} key={path} />
				))}

				{/* Medulla Interface Routes */}
				<Route path='/medulla/result/:tc/:prescription' element={<Prescription />} />
				<Route path='/medulla' element={<CreatePrescription />} />

				{/* Not Found Page */}
				<Route path='*' element={<h1>Page Not Found!</h1>} />
			</Routes>
		</div>
	)
}
