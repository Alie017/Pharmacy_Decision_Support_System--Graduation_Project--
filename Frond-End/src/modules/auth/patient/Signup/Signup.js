import React, { useState } from 'react'
import { api } from '../../../../services/api'
import { toast } from 'react-toastify'
import { useFormik } from 'formik'
import { FaUserInjured } from 'react-icons/fa'
import { Link, useNavigate } from 'react-router-dom'
import Layout from '../../Layout/Layout'
import styles from './Signup.module.css'

export default function Signup() {
	const navigate = useNavigate()

	const [error, setError] = useState('')

	const [validationError, setValidationError] = useState([])

	const formik = useFormik({
		initialValues: {
			name: '',
			surname: '',
			userName: '',
			emailAddress: '',
			password: '',
		},
		onSubmit: async values => {
			try {
				const res = await api.post('/services/app/Account/Register', values)
				console.log(res.data)
				if(res.data.success) {
					navigate('/signin/patient')
					toast.success('Signed up successfully')
				}
			} catch (err) {
				toast.error('Failed to sign up')
				setError(err.response.data.error.message)
				setValidationError(err.response.data.error.validationErrors)
			}
		}
	})

  return (
		<Layout>
			<div className={styles.icon}>
				<FaUserInjured />
			</div>
			<h3 className={styles.formTitle}>Sign Up</h3>
			{error && <p className='error'>{error}</p>}
			{validationError &&
				validationError.map(err => <p className='error'>{err.message}</p>)}
			<form className={styles.form} onSubmit={formik.handleSubmit}>
				<div className={styles.formGroup}>
					<label htmlFor='name'>Name</label>
					<input
						type='text'
						name='name'
						placeholder='Enter your name'
						onChange={formik.handleChange}
						value={formik.values.name}
					/>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='surname'>Surname</label>
					<input
						type='text'
						name='surname'
						placeholder='Enter your surname'
						onChange={formik.handleChange}
						value={formik.values.surname}
					/>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='username'>Username</label>
					<input
						type='text'
						name='userName'
						placeholder='Enter your userName'
						onChange={formik.handleChange}
						value={formik.values.userName}
					/>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='emailAddress'>Email</label>
					<input
						type='email'
						name='emailAddress'
						placeholder='Enter your email'
						onChange={formik.handleChange}
						value={formik.values.emailAddress}
					/>
				</div>
				<div className={styles.formGroup}>
					<label htmlFor='password'>Password</label>
					<input
						type='password'
						name='password'
						placeholder='Enter your password'
						onChange={formik.handleChange}
						value={formik.values.password}
					/>
				</div>
				<div className={styles.formGroup}>
					<button type='submit'>Sign up</button>
				</div>
			</form>
			<div className={styles.divider}>
				<span className={styles.line}></span>
				<span className={styles.text}>or</span>
				<span className={styles.line}></span>
			</div>
			<Link to='/signup/pharmacist' className={styles.signUpAsBtn}>
				Sign up as pharmacist
			</Link>
			<p className={styles.haveAnAccount}>
				Have an account? Click <Link to='/signin/patient'>here</Link>
			</p>
		</Layout>
	)
}
